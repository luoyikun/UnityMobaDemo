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

    public  sealed class ReqMatch :  Bright.Serialization.BeanBase 
    {
        public ReqMatch()
        {
        }

        public ReqMatch(Bright.Common.NotNullInitialization _) 
        {
        }

        public static void SerializeReqMatch(ByteBuf _buf, ReqMatch x)
        {
            x.Serialize(_buf);
        }

        public static ReqMatch DeserializeReqMatch(ByteBuf _buf)
        {
            var x = new HOKProtocol.ReqMatch();
            x.Deserialize(_buf);
            return x;
        }

         public HOKProtocol.PvpEnum pvpEnum;


        public const int __ID__ = 0;
        public override int GetTypeId() => __ID__;

        public override void Serialize(ByteBuf _buf)
        {
            _buf.WriteInt((int)pvpEnum);
        }

        public override void Deserialize(ByteBuf _buf)
        {
            pvpEnum = (HOKProtocol.PvpEnum)_buf.ReadInt();
        }

        public override string ToString()
        {
            return "HOKProtocol.ReqMatch{ "
            + "pvpEnum:" + pvpEnum + ","
            + "}";
        }
    }

}
