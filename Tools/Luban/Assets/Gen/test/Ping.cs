//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;

namespace proto.test
{

    public  sealed class Ping :  Bright.Serialization.BeanBase 
    {
        public Ping()
        {
        }

        public Ping(Bright.Common.NotNullInitialization _) 
        {
        }

        public static void SerializePing(ByteBuf _buf, Ping x)
        {
            x.Serialize(_buf);
        }

        public static Ping DeserializePing(ByteBuf _buf)
        {
            var x = new test.Ping();
            x.Deserialize(_buf);
            return x;
        }

         public bool IsOver;


        public const int __ID__ = 0;
        public override int GetTypeId() => __ID__;

        public override void Serialize(ByteBuf _buf)
        {
            _buf.WriteBool(IsOver);
        }

        public override void Deserialize(ByteBuf _buf)
        {
            IsOver = _buf.ReadBool();
        }

        public override string ToString()
        {
            return "test.Ping{ "
            + "IsOver:" + IsOver + ","
            + "}";
        }
    }

}
