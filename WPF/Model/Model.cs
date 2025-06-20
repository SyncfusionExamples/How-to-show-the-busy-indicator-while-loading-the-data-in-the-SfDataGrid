using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class Model : NotificationObject
    {
        private int _employeeId;
        public int EmployeeId
        {
            get
            {
                return _employeeId;
            }
            set
            {
                _employeeId = value;
                this.RaisePropertyChanged("EmployeeId");
            }
        }

        private string _employeeName;
        public string EmployeeName
        {
            get
            {
                return _employeeName;
            }
            set
            {
                _employeeName = value;
                this.RaisePropertyChanged("EmployeeName");
            }
        }

        private string _employeeDesignation;
        public string EmployeeDesignation
        {
            get
            {
                return _employeeDesignation;
            }
            set
            {
                _employeeDesignation = value;
                this.RaisePropertyChanged("EmployeeDesignation");
            }
        }

        private int _employeeAge;
        public int EmployeeAge
        {
            get
            {
                return _employeeAge;
            }
            set
            {
                _employeeAge = value;
                this.RaisePropertyChanged("EmployeeAge");
            }
        }

        private string _employeeArea;
        public string EmployeeArea
        {
            get
            {
                return _employeeArea;
            }
            set
            {
                _employeeArea = value;
                this.RaisePropertyChanged("EmployeeArea");
            }
        }

        private string _employeeGender;
        public string EmployeeGender
        {
            get
            {
                return _employeeGender;
            }
            set
            {
                _employeeGender = value;
                this.RaisePropertyChanged("EmployeeGender");
            }
        }

        private int _experienceInMonth;
        public int ExperienceInMonth
        {
            get
            {
                return _experienceInMonth;
            }
            set
            {
                _experienceInMonth = value;
                this.RaisePropertyChanged("ExperienceInMonth");
            }
        }

        private double _employeeSalary;
        public double EmployeeSalary
        {
            get
            {
                return _employeeSalary;
            }
            set
            {
                _employeeSalary = value;
                this.RaisePropertyChanged("EmployeeSalary");
            }
        }
    }
}
