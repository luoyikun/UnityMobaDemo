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

    public  sealed class NotifyChat :  Bright.Serialization.BeanBase 
    {
        public NotifyChat()
        {
        }

        public NotifyChat(Bright.Common.NotNullInitialization _) 
        {
            chatMsg = "";
        }

        public static void SerializeNotifyChat(ByteBuf _buf, NotifyChat x)
        {
            x.Serialize(_buf);
        }

        public static NotifyChat DeserializeNotifyChat(ByteBuf _buf)
        {
            var x = new HOKProtocol.NotifyChat();
            x.Deserialize(_buf);
            return x;
        }

         public string chatMsg;


        public const int __ID__ = 0;
        public override int GetTypeId() => __ID__;

        public override void Serialize(ByteBuf _buf)
        {
            _buf.WriteString(chatMsg);
        }

        public override void Deserialize(ByteBuf _buf)
        {
            chatMsg = _buf.ReadString();
        }

        public override string ToString()
        {
            return "HOKProtocol.NotifyChat{ "
            + "chatMsg:" + chatMsg + ","
            + "}";
        }
    }

}
