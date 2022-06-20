using Big_School.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Big_School.Controllers
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;

        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend([FromBody] int courseId)
        {
            var attendance = new Attendance
            {
                CourseId = courseId,
                AttendeeId = User.Identity.GetUserId()
            };

            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
            return Ok();
        }
        /*
                [HttpPost]
                public IHttpActionResult Attend(AttendanceDto attendanceDto)
                {
                    var uerId = User.Identity.GetUserId();
                    if (_dbContext.Attendances.Any(a => a.AttendeeId == uerId && a.CourseId == attendanceDto.CourseId))
                        return BadRequest("The Attendence alrealy exists");
                    var attendace = new Attendance
                    {
                        CourseId = attendanceDto.CourseId,
                        AttendeeId = User.Identity.GetUserId()
                    };
                    _dbContext.Attendances.Add(attendace);
                    _dbContext.SaveChanges();
                    return Ok();
                }*/
    }
}