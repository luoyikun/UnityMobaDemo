//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg
{

public sealed partial class NormalBuffCfg :  BuffCfg 
{
    public NormalBuffCfg(ByteBuf _buf)  : base(_buf) 
    {
        PostInit();
    }

    public static NormalBuffCfg DeserializeNormalBuffCfg(ByteBuf _buf)
    {
        return new NormalBuffCfg(_buf);
    }


    public const int __ID__ = -993297398;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "buffId:" + buffId + ","
        + "buffName:" + buffName + ","
        + "buffType:" + buffType + ","
        + "attacher:" + attacher + ","
        + "staticPosType:" + staticPosType + ","
        + "impacter:" + impacter + ","
        + "buffDelay:" + buffDelay + ","
        + "buffInterval:" + buffInterval + ","
        + "buffDuration:" + buffDuration + ","
        + "buffAudio:" + buffAudio + ","
        + "buffEffect:" + buffEffect + ","
        + "hitTickAudio:" + hitTickAudio + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}