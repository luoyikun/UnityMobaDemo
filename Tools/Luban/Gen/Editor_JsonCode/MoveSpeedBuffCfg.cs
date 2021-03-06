//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace editor.cfg
{

public sealed partial class MoveSpeedBuffCfg :  BuffCfg 
{
    public MoveSpeedBuffCfg()
    {
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        base.LoadJson(_json);
        { 
            var _fieldJson = _json["amount"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  amount = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        base.SaveJson(_json);
        {
            _json["amount"] = new JSONNumber(amount);
        }
    }

    public static MoveSpeedBuffCfg LoadJsonMoveSpeedBuffCfg(SimpleJSON.JSONNode _json)
    {
        MoveSpeedBuffCfg obj = new MoveSpeedBuffCfg();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonMoveSpeedBuffCfg(MoveSpeedBuffCfg _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    /// <summary>
    /// 速度改变量，百分比
    /// </summary>
    public int amount { get; set; }

}
}
