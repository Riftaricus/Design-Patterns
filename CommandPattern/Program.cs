using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            /* Define and instantiate the following Vendor classes
             * Kitchen Light : Light
             * Livingroom Light : Light
             * Livingroom ceiling fan : CeilingFan
             * Garage door: Garagedoor
             * Stereo : Stereo
             */
            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            CeilingFan livingRoomCeilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor(livingRoomLight);
            Stereo stereo = new Stereo();
            // Define and instantiate an Off and On command for each Vendor class

            remoteControl.SetCommand(0, new LightOnCommand(livingRoomLight), new LightOffCommand(livingRoomLight));
            remoteControl.SetCommand(1, new LightOnCommand(kitchenLight), new LightOffCommand(kitchenLight));
            remoteControl.SetCommand(2, new CeilingFanHighCommand(livingRoomCeilingFan), new CeilingFanOffCommand(livingRoomCeilingFan));
            remoteControl.SetCommand(3, new GarageDoorUpCommand(garageDoor), new GarageDoorDownCommand(garageDoor));
            remoteControl.SetCommand(4, new StereoOnWithRadioCommand(stereo), new StereoOffCommand(stereo));


            /* Set the On and Off commands to the appropriate slot:
             * 
             * 1: Living Room light
             * 2: Kitchen light
             * 3: Livingroom ceiling fan
             * 4: Garage door
             * 5: Stereo
             */
            Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.Undo();

            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.Undo();

            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);
            remoteControl.Undo();

            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);
            remoteControl.Undo();

            remoteControl.OnButtonWasPushed(4);
            remoteControl.OffButtonWasPushed(4);
            remoteControl.Undo();


        }
    }
}