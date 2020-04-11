using apbd_tut6.DTO.Requests;
using apbd_tut6.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial6.Models;

namespace Tutorial6.Services
{
    public interface IStudentsSerivceDb
    {
        IEnumerable<Student> GetStudents();

        IEnumerable<string> GetSemester(string id);
        //------------------------------------------5th assignment-------------------------------//
        EnrollStudentResponse EnrollStudent(EnrollStudentRequest req);

        PromoteStudentResponse PromoteStudent(PromoteStudentRequest req);
        //------------------------------------------6th assignment-------------------------------//
        bool idExists(string id);

        void logIntoFile(string data);
    }
}
