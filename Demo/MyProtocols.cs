using KoboldCom;
using System.Collections.Generic;

namespace Demo
{
    public class MyProtocols : IAnalyzerCollection
    {
        private readonly IAnalyzer[] _innerArray;
        public DemoTextProtocol protocolText= new DemoTextProtocol();
         public DemoHexProtocol protocolBinary = new DemoHexProtocol();
        public MyProtocols()
        {
            _innerArray = new IAnalyzer[] { ProtocolText, ProtocolBinary };
        }
        public DemoTextProtocol ProtocolText {
            get { return protocolText; }
            set { protocolText = value; }
        } 
        public DemoHexProtocol ProtocolBinary { 
            get{return protocolBinary;}
            set { protocolBinary = value; }
        }


        // public int StaticLength
        //{
        //    get { return _stickLength; }
        //    set { _stickLength = value < 0 ? 0 : value; }
        //}

        //public DemoTextProtocol ProtocolText
        //{
        //    get { return (DemoTextProtocol)_innerArray[0]; }
        //    set { value = new DemoTextProtocol(); }// = new DemoTextProtocol();
        //}
        //public DemoHexProtocol ProtocolBinary
        //{
        //    get { return (DemoHexProtocol)_innerArray[1]; } //= new DemoHexProtocol();
        //    set{value = new DemoHexProtocol();}
            
        //}
          //get { return this._serialPort.Encoding; }
            //set { this._serialPort.Encoding = value; }
        //public DemoTextProtocol ProtocolText { 
        //    get;
        //    //{
        //    //    //return (DemoTextProtocol)_innerArray[0];
        //    // //   return new DemoTextProtocol();
        //    //} 
        //set; 
        //    //{ _innerArray[0] = value; }
        //} 
       // public DemoHexProtocol ProtocolBinary { get;set{value = new DemoHexProtocol(); }} 

        public IAnalyzer this[int index]
        {
            get
            {
                return _innerArray[index];
            }
        }

        public IEnumerator<IAnalyzer> GetEnumerator()
        {
            return ((IEnumerable<IAnalyzer>)_innerArray).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerArray.GetEnumerator();
        }
    }
}
