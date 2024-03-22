
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LuBan.Runtime;
using SimpleJSON;


namespace cfg.ai
{
    
    public sealed partial class BlackboardKey : LuBan.Runtime.BeanBase
    {
        public BlackboardKey(JSONNode _buf) 
        {
            { if(!_buf["name"].IsString) { throw new SerializationException(); }  Name = _buf["name"]; }
            { if(!_buf["desc"].IsString) { throw new SerializationException(); }  Desc = _buf["desc"]; }
            { if(!_buf["is_static"].IsBoolean) { throw new SerializationException(); }  IsStatic = _buf["is_static"]; }
            { if(!_buf["type"].IsNumber) { throw new SerializationException(); }  Type = (ai.EKeyType)_buf["type"].AsInt; }
            { if(!_buf["type_class_name"].IsString) { throw new SerializationException(); }  TypeClassName = _buf["type_class_name"]; }
        }
    
        public static BlackboardKey DeserializeBlackboardKey(JSONNode _buf)
        {
            return new ai.BlackboardKey(_buf);
        }
    
        public readonly string Name;
        public readonly string Desc;
        public readonly bool IsStatic;
        public readonly ai.EKeyType Type;
        public readonly string TypeClassName;
       
        public const int __ID__ = -511559886;
        public override int GetTypeId() => __ID__;
    
        public  void ResolveRef(Tables tables)
        {
            
            
            
            
            
        }
    
        public override string ToString()
        {
            return "{ "
            + "name:" + Name + ","
            + "desc:" + Desc + ","
            + "isStatic:" + IsStatic + ","
            + "type:" + Type + ","
            + "typeClassName:" + TypeClassName + ","
            + "}";
        }
    }

}
