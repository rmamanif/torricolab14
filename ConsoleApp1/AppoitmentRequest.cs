using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class AppoitmentRequest
    {
        public int appointmentId { get; set; }
        public string appointmentNumber { get; set; }

        public DateTime registeredAppointmentDateTime { get; set; }
        public string appointmentURL { get; set; }

        public string classCode { get; set; }

        public string wicId { get; set; }


    }
}
