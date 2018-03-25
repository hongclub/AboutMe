using AboutMe.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboutMe.Models.DataManager
{
    public class AppointmentManager : IDataRepository<Appointment, long>
    {
        ApplicationContext ctx;
        public AppointmentManager(ApplicationContext c)
        {
            ctx = c;
        }

        public Appointment Get(long id)
        {
            var appointment = ctx.Appointments.FirstOrDefault(b => b.Id == id);
            return appointment;
        }

        public IEnumerable<Appointment> GetAll()
        {
            var appointments = ctx.Appointments.ToList();
            return appointments;
        }


        public long Add(Appointment appointment)
        {
            ctx.Appointments.Add(appointment);
            long appointmentID = ctx.SaveChanges();
            return appointmentID;
        }

        public long Delete(long id)
        {
            int appointmentID = 0;
            var appointment = ctx.Appointments.FirstOrDefault(b => b.Id == id);
            if (appointment != null)
            {
                ctx.Appointments.Remove(appointment);
                appointmentID = ctx.SaveChanges();
            }
            return appointmentID;
        }

        public long Update(long id, Appointment item)
        {
            long appointmentID = 0;
            var appointment = ctx.Appointments.Find((int)id);

            if (appointment != null)
            {
                appointment.Title = item.Title;
                appointment.Description = item.Description;
                appointment.ObjectId = item.ObjectId;
                appointment.ObjectType = item.ObjectType;
                appointment.Date = item.Date;
                appointment.ModifiedDate = item.ModifiedDate;

                appointmentID = ctx.SaveChanges();
            }

            return appointmentID;
        }

    }
}
