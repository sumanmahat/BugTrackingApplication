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
        private string imgfile;
        private string projectname, classname, method, lineno,endline, errorsnap,author, year, month, 
        day, sourcecode, status, addedby, solver, solveyear, solvemonth, solveday, solvecode;

        public string Addedby
        {
            get
            {
                return Addedby1;
            }

            set
            {
                Addedby1 = value;
            }
        }

        public string Addedby1
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
                return Author1;
            }

            set
            {
                Author1 = value;
            }
        }

        public string Author1
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
                return Classname1;
            }

            set
            {
                Classname1 = value;
            }
        }

        public string Classname1
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
                return Day1;
            }

            set
            {
                Day1 = value;
            }
        }

        public string Day1
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

        public string Endline
        {
            get
            {
                return endline;
            }

            set
            {
                endline = value;
            }
        }

        public string Errorsnap
        {
            get
            {
                return Errorsnap1;
            }

            set
            {
                Errorsnap1 = value;
            }
        }

        public string Errorsnap1
        {
            get
            {
                return errorsnap;
            }

            set
            {
                errorsnap = value;
            }
        }

        public string Imgfile
        {
            get
            {
                return imgfile;
            }

            set
            {
                imgfile = value;
            }
        }

        public string Lineno
        {
            get
            {
                return Lineno1;
            }

            set
            {
                Lineno1 = value;
            }
        }

        public string Lineno1
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
                return Method1;
            }

            set
            {
                Method1 = value;
            }
        }

        public string Method1
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
                return Month1;
            }

            set
            {
                Month1 = value;
            }
        }

        public string Month1
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
                return Projectname1;
            }

            set
            {
                Projectname1 = value;
            }
        }

        public string Projectname1
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
                return Solvecode1;
            }

            set
            {
                Solvecode1 = value;
            }
        }

        public string Solvecode1
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
                return Solveday1;
            }

            set
            {
                Solveday1 = value;
            }
        }

        public string Solveday1
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
                return Solvemonth1;
            }

            set
            {
                Solvemonth1 = value;
            }
        }

        public string Solvemonth1
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
                return Solver1;
            }

            set
            {
                Solver1 = value;
            }
        }

        public string Solver1
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
                return Solveyear1;
            }

            set
            {
                Solveyear1 = value;
            }
        }

        public string Solveyear1
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
                return Sourcecode1;
            }

            set
            {
                Sourcecode1 = value;
            }
        }

        public string Sourcecode1
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
                return Status1;
            }

            set
            {
                Status1 = value;
            }
        }

        public string Status1
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
                return Year1;
            }

            set
            {
                Year1 = value;
            }
        }

        public string Year1
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
