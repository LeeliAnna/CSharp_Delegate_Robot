using CSharp_Delegate_Robot.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Delegate_Robot.Models
{
    public class RobotEventArgs : EventArgs
    {
        public string Message { get; set; }
        public MessageType MessageType { get; set; }


        public RobotEventArgs(MessageType messageType, string message)
        {
            Message = message;
            MessageType = messageType;
        }

    }
}
