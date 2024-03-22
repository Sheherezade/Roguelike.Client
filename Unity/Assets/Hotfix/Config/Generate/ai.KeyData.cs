
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
    
    public abstract partial class KeyData : LuBan.Runtime.BeanBase
    {
        public KeyData(JSONNode _buf) 
        {
        }
    
        public static KeyData DeserializeKeyData(JSONNode _buf)
        {
            switch ((string)_buf["$type"])
            {
                case "FloatKeyData": return new ai.FloatKeyData(_buf);
                case "IntKeyData": return new ai.IntKeyData(_buf);
                case "StringKeyData": return new ai.StringKeyData(_buf);
                case "BlackboardKeyData": return new ai.BlackboardKeyData(_buf);
                default: throw new SerializationException();
            }
        }
    
       
    
        public virtual void ResolveRef(Tables tables)
        {
        }
    
        public override string ToString()
        {
            return "{ "
            + "}";
        }
    }

}
