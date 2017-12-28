﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tripper.WinLogic.Forms;
using Tripper.DbLogic.LinqToSQL;
using Tripper.DbLogic;
using Tripper.WinLogic.Classes;

namespace Tripper.WinLogic.UserControls
{
    public partial class TripListRow : ListRowPureControl
    {


        NewTripCreator tripDetails;

        private Trip _selectedTrip;
        public Trip SelectedTrip
        {
            get
            {
                return _selectedTrip;
            }
            set
            {
                _selectedTrip = value;
            }
        }

        public TripListRow()
        {
            InitializeComponent();
        }

        public TripListRow(Trip trip)
        {
            SelectedTrip = trip;
            InitializeComponent();
            setTripInfo(trip);
        }

        public Button EditButton
        {
            get
            {
                return bEdit;
            }
        }

        private void setTripInfo(Trip trip)
        {
            lTripName.Text = trip.Name;
            Transport firstTransport = Connection.TripperData.Transports.Where(transport => transport.Trip.Equals(trip)).OrderBy(transport => transport.DepartureTime).First();
            Localization city = Connection.TripperData.Localizations.Single(loc => loc.LocalizationID.Equals(firstTransport.ArrivalLocalization));
            lDestination.Text = Connection.TripperData.Countries.Single(country => country.CountryID.Equals(city.CountryID)).Name.ToString() + ", " + city.City;
            if (firstTransport.DepartureTime != null)
            {
                DateTime date = DateTime.Parse(firstTransport.DepartureTime.ToString());

                lStartDate.Text = date.ToShortDateString();
            }
            else
                lStartDate.Text = "Nie ustalono terminu";

            if (firstTransport.DepartureTime > DateTime.Today)
            {
                TimeSpan tempDays = DateTime.Parse(firstTransport.DepartureTime.ToString()).Date - DateTime.Today.Date;
                int daysTo = int.Parse(tempDays.Days.ToString());

                string day = daysTo > 1 ? "dni" : "dzień";
                lDaysCount.Text = "Podróż rozpocznie się za " + daysTo + " " + day;
            }
            else
                lDaysCount.Text = "Podróż odbyła się";
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            CurrentTrip.Trip = SelectedTrip;
        }
    }
}
