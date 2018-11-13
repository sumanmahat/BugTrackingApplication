using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking_Aplication_suman_mahat.Model
{
    class Bugs
    {
        private int bugId;
        private string projectname, classname, method, lineno, author, year, month, 
        day, sourcecode, status, addedby, solver, solveyear, solvemonth, solveday, solvecode;

        public string Addedby
        {
            get
            {
                return addedby;
            }

            set
            {
                addedby = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public int BugId
        {
            get
            {
                return bugId;
            }

            set
            {
                bugId = value;
            }
        }

        public string Classname
        {
            get
            {
                return classname;
            }

            set
            {
                classname = value;
            }
        }

        public string Day
        {
            get
            {
                return day;
            }

            set
            {
                day = value;
            }
        }

        public string Lineno
        {
            get
            {
                return lineno;
            }

            set
            {
                lineno = value;
            }
        }

        public string Method
        {
            get
            {
                return method;
            }

            set
            {
                method = value;
            }
        }

        public string Month
        {
            get
            {
                return month;
            }

            set
            {
                month = value;
            }
        }

        public string Projectname
        {
            get
            {
                return projectname;
            }

            set
            {
                projectname = value;
            }
        }

        public string Solvecode
        {
            get
            {
                return solvecode;
            }

            set
            {
                solvecode = value;
            }
        }

        public string Solveday
        {
            get
            {
                return solveday;
            }

            set
            {
                solveday = value;
            }
        }

        public string Solvemonth
        {
            get
            {
                return solvemonth;
            }

            set
            {
                solvemonth = value;
            }
        }

        public string Solver
        {
            get
            {
                return solver;
            }

            set
            {
                solver = value;
            }
        }

        public string Solveyear
        {
            get
            {
                return solveyear;
            }

            set
            {
                solveyear = value;
            }
        }

        public string Sourcecode
        {
            get
            {
                return sourcecode;
            }

            set
            {
                sourcecode = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public string Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }
    }
}
