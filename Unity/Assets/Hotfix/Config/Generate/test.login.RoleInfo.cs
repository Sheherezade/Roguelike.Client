
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LuBan.Runtime;
using SimpleJSON;


namespace cfg.test.login
{
    
    public sealed partial class RoleInfo : test.DemoD3
    {
        public RoleInfo(JSONNode _buf)  : base(_buf) 
        {
            { if(!_buf["role_id"].IsNumber) { throw new SerializationException(); }  RoleId = _buf["role_id"]; }
        }
    
        public static RoleInfo DeserializeRoleInfo(JSONNode _buf)
        {
            return new test.login.RoleInfo(_buf);
        }
    
        public readonly long RoleId;
       
        public const int __ID__ = -989153243;
        public override int GetTypeId() => __ID__;
    
        public override void ResolveRef(Tables tables)
        {
            base.ResolveRef(tables);
            
        }
    
        public override string ToString()
        {
            return "{ "
            + "x1:" + X1 + ","
            + "x3:" + X3 + ","
            + "roleId:" + RoleId + ","
            + "}";
        }
    }

}
