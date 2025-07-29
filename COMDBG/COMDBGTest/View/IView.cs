using System;

namespace COMDBG.View
{
    public interface IView
    {
        void SetController(IController controller);

        //Open serial port event
        void OpenComEvent(Object sender, SerialPortEventArgs e);

        //Close serial port event
        void CloseComEvent(Object sender, SerialPortEventArgs e);

        //Serial port receive data event
        void ComReceiveDataEvent(Object sender, SerialPortEventArgs e);
    }
}
