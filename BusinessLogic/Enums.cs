﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripper.BusinessLogic
{
 
        public enum CreatorMode
        {
            AddNew, Edit
        }

        public enum CreatorStatus
        {
            Edit, Confirmed
        }

        public enum DetailsViewMode
        {
            ListView, AddNew
        }

        public enum NoteType
        {
            CheckBox, Note
        }
}
