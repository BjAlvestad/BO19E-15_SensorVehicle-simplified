﻿using System;
using System.Threading;
using VehicleEquipment.DistanceMeasurement.Lidar;
using VehicleEquipment.DistanceMeasurement.Ultrasound;
using VehicleEquipment.Locomotion.Encoder;
using VehicleEquipment.Locomotion.Wheels;

namespace StudentLogic.Student1
{
    public class Student1A : StudentLogicBase
    {
        public override StudentLogicDescription Details { get; }
        
        public Student1A(IWheel wheel, IEncoders encoders, ILidarDistance lidar, IUltrasonic ultrasonic) : base(wheel)
        {
            Details = new StudentLogicDescription
            {
                Title = "Empty logic for Student 1 (A)",
                Author = "Student 1",
                Description = "This program is empty.\n" +
                              "Write your control logic in the looping Run() method.\n" +
                              "(And change Title, Author and Description).\n" +
                              $"All this is done in the {nameof(Student1A)}.cs file."
            };

            _wheels = wheel;
            _lidar = lidar;
            _ultrasonic = ultrasonic;
            _encoders = encoders;
        }

        public override void Initialize()
        {
            // If you have any code you want to run ONCE when starting the control logic, you may put that here (optional).
            // E.g. setting desired number of collection cycles for LIDAR, or default vertical angle etc.

        }

        private IWheel _wheels;
        private ILidarDistance _lidar;
        private IUltrasonic _ultrasonic;
        private IEncoders _encoders;
        public override void Run(CancellationToken cancellationToken)
        {
            // ** WRITE YOUR CONTROL LOGIC HERE **
            // The Run() method will loop until control logic is stopped (or exception occurs)
            // If you write your own loops inside here, then remember to add '&& !cancellationToken.IsCancellationRequested' to the loop check
            
            // The 'throw new NotImplementedException(...)' line below must be removed before you can start the control logic.
            throw new NotImplementedException($"You must write control logic in the Run() method of \'{nameof(Student1A)}\' first.\n" +
                                              $"Remember to delete the \'throw new NotImplementedException(...)\' before attempting to run it.");
        }
    }
}
