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

    public  sealed class SendSelect :  Bright.Serialization.BeanBase 
    {
        public SendSelect()
        {
        }

        public SendSelect(Bright.Common.NotNullInitialization _) 
        {
        }

        public static void SerializeSendSelect(ByteBuf _buf, SendSelect x)
        {
            x.Serialize(_buf);
        }

        public static SendSelect DeserializeSendSelect(ByteBuf _buf)
        {
            var x = new HOKProtocol.SendSelect();
            x.Deserialize(_buf);
            return x;
        }

         public int roomId;

         public int heroId;


        public const int __ID__ = 0;
        public override int GetTypeId() => __ID__;

        public override void Serialize(ByteBuf _buf)
        {
            _buf.WriteInt(roomId);
            _buf.WriteInt(heroId);
        }

        public override void Deserialize(ByteBuf _buf)
        {
            roomId = _buf.ReadInt();
            heroId = _buf.ReadInt();
        }

        public override string ToString()
        {
            return "HOKProtocol.SendSelect{ "
            + "roomId:" + roomId + ","
            + "heroId:" + heroId + ","
            + "}";
        }
    }

}
