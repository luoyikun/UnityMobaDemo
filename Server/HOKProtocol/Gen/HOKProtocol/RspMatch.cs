//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;

namespace proto.HOKProtocol
{

    public  sealed class RspMatch :  Bright.Serialization.BeanBase 
    {
        public RspMatch()
        {
        }

        public RspMatch(Bright.Common.NotNullInitialization _) 
        {
        }

        public static void SerializeRspMatch(ByteBuf _buf, RspMatch x)
        {
            x.Serialize(_buf);
        }

        public static RspMatch DeserializeRspMatch(ByteBuf _buf)
        {
            var x = new HOKProtocol.RspMatch();
            x.Deserialize(_buf);
            return x;
        }

         public int preTime;


        public const int __ID__ = 0;
        public override int GetTypeId() => __ID__;

        public override void Serialize(ByteBuf _buf)
        {
            _buf.WriteInt(preTime);
        }

        public override void Deserialize(ByteBuf _buf)
        {
            preTime = _buf.ReadInt();
        }

        public override string ToString()
        {
            return "HOKProtocol.RspMatch{ "
            + "preTime:" + preTime + ","
            + "}";
        }
    }

}