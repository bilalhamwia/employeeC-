using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPage
{
     class Employee:Person
    {
        public double salary;
        public int age;
        public Position postion;
        public bool IsManager;
        public bool IsTeamLeader;
        public List<Skills> skills = new List<Skills>();
        public Team team;
        public Employee manager;
        public string userName;
        public string password;
        public List<Evaluation> evaluations = new List<Evaluation>();



        public Employee(string firstName, string lastName,double salary,int age, Position postion) : base(firstName, lastName)
 
        {
            this.salary = salary;
            this.age = age;
            userName = firstName;
            password = "admin";
            this.postion=postion;
            IsManager = false;
            IsTeamLeader = false;
            manager = null;
        }

        public Employee(string firstName, string lastName, double salary, int age, Position postion, Employee employee) : this(firstName, lastName, salary, age, postion)

        {
            this.manager = employee;
        }
    }
}
