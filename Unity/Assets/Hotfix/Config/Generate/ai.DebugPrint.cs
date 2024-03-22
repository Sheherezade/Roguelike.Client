
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
    
    public sealed partial class DebugPrint : ai.Task
    {
        public DebugPrint(JSONNode _buf)  : base(_buf) 
        {
            { if(!_buf["text"].IsString) { throw new SerializationException(); }  Text = _buf["text"]; }
        }
    
        public static DebugPrint DeserializeDebugPrint(JSONNode _buf)
        {
            return new ai.DebugPrint(_buf);
        }
    
        public readonly string Text;
       
        public const int __ID__ = 1357409728;
        public override int GetTypeId() => __ID__;
    
        public override void ResolveRef(Tables tables)
        {
            base.ResolveRef(tables);
            
        }
    
        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "nodeName:" + NodeName + ","
            + "decorators:" + StringUtil.CollectionToString(Decorators) + ","
            + "services:" + StringUtil.CollectionToString(Services) + ","
            + "ignoreRestartSelf:" + IgnoreRestartSelf + ","
            + "text:" + Text + ","
            + "}";
        }
    }

}
