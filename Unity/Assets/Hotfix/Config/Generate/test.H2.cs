
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LuBan.Runtime;
using SimpleJSON;


namespace cfg.test
{
    
    public sealed partial class H2 : LuBan.Runtime.BeanBase
    {
        public H2(JSONNode _buf) 
        {
            { if(!_buf["z2"].IsNumber) { throw new SerializationException(); }  Z2 = _buf["z2"]; }
            { if(!_buf["z3"].IsNumber) { throw new SerializationException(); }  Z3 = _buf["z3"]; }
        }
    
        public static H2 DeserializeH2(JSONNode _buf)
        {
            return new test.H2(_buf);
        }
    
        public readonly int Z2;
        public readonly int Z3;
       
        public const int __ID__ = -1422503994;
        public override int GetTypeId() => __ID__;
    
        public  void ResolveRef(Tables tables)
        {
            
            
        }
    
        public override string ToString()
        {
            return "{ "
            + "z2:" + Z2 + ","
            + "z3:" + Z3 + ","
            + "}";
        }
    }

}
