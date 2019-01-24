using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectInfo
{
    class ProjectInfoClass
    {
        private string projectName;
        private string projectType;
        private string projectDescription;
        private string projectUser;
        private string projectDate;

        public ProjectInfoClass ()
        {
            Name = "";
            Type = "";
            Description = "";
            User = "";
            Date = "";
        }

        public string Name
        {
            get
            {
                return projectName;
            }

            set
            {
                projectName = value;
            }
        }

        public string Type
        {
            get
            {
                return projectType;
            }

            set
            {
                projectType = value;
            }
        }

        public string Description
        {
            get
            {
                return projectDescription;
            }

            set
            {
                projectDescription = value;
            }
        }

        public string User
        {
            get
            {
                return projectUser;
            }

            set
            {
                projectUser = value;
            }
        }

        public string Date
        {
            get
            {
                return projectDate;
            }

            set
            {
                projectDate = value;
            }
        }

        public Boolean FileNameValid ()
        {
            Boolean fileNameValid = true;

            if ( !NameNotEmpty() )
            {
                return false;
            }

            else if ( !TypeNotEmpty() )
            {
                return false;
            }

            return fileNameValid;
        }

        public string GenerateFileName ()
        {
            //string fileName = "";

            string fileName = Name;

            if ( TypeNotEmpty() )
            {
                fileName += "_" + Type;
            }

            if ( DescriptionNotEmpty() )
            {
                fileName += "_" + Description;
            }

            if ( UserNotEmpty() )
            {
                fileName += "_" + User;
            }

            if ( DateNotEmpty())
            {
                fileName += "_" + Date;
            }

            return fileName;
        }

        public Boolean NameNotEmpty ()
        {
            if (Name == "")
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public Boolean TypeNotEmpty ()
        {
            if (Type == "")
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public Boolean DescriptionNotEmpty ()
        {
            if (Description == "")
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public Boolean UserNotEmpty ()
        {
            if (User == "")
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public Boolean DateNotEmpty ()
        {
            if (Date == "")
            {
                return false;
            }

            else
            {
                return true;
            }
        } 
    }
}
