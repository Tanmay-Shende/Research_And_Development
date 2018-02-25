using System;

namespace Algorithms.Abstraction
{

    public interface Iplane
    {
        void Speed(int newSpeed);

        void Turn(int angle);

        void Stop();//Added Comment.-- 

        void CheckCarHealth();//Release Branch


        void CheckBattery(); //Dev

        void RemoteStart();

    }

    public abstract class Plane
    {
        public abstract void Speed(int newSpeed);

        public void Turn(int angle)
        {
            Console.WriteLine("Angel" + angle.ToString());
        }

        public void Stop()
        {
            Console.WriteLine("Angel");
        }
    }

    public abstract class Car
    {
        public virtual void Speed(int newSpeed)
        {
            Console.WriteLine("Speed Increased : " + newSpeed.ToString());
        }

        public virtual void Turn(int angle)
        {
            Console.WriteLine("Angel" + angle.ToString());
        }
    }
}
