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

    public  sealed class BagItemData :  Bright.Serialization.BeanBase 
    {
        public BagItemData()
        {
        }

        public BagItemData(Bright.Common.NotNullInitialization _) 
        {
        }

        public static void SerializeBagItemData(ByteBuf _buf, BagItemData x)
        {
            x.Serialize(_buf);
        }

        public static BagItemData DeserializeBagItemData(ByteBuf _buf)
        {
            var x = new HOKProtocol.BagItemData();
            x.Deserialize(_buf);
            return x;
        }

         public int itemId;

         public int itemNum;


        public const int __ID__ = 0;
        public override int GetTypeId() => __ID__;

        public override void Serialize(ByteBuf _buf)
        {
            _buf.WriteInt(itemId);
            _buf.WriteInt(itemNum);
        }

        public override void Deserialize(ByteBuf _buf)
        {
            itemId = _buf.ReadInt();
            itemNum = _buf.ReadInt();
        }

        public override string ToString()
        {
            return "HOKProtocol.BagItemData{ "
            + "itemId:" + itemId + ","
            + "itemNum:" + itemNum + ","
            + "}";
        }
    }

}