
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
    
    public sealed partial class TestSet : LuBan.Runtime.BeanBase
    {
        public TestSet(JSONNode _buf) 
        {
            { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
            { if(!_buf["x0"].IsString) { throw new SerializationException(); }  X0 = _buf["x0"]; }
            { var __json0 = _buf["x1"]; if(!__json0.IsArray) { throw new SerializationException(); } X1 = new System.Collections.Generic.List<int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  X1.Add(__v0); }   }
            { var __json0 = _buf["x2"]; if(!__json0.IsArray) { throw new SerializationException(); } X2 = new System.Collections.Generic.List<long>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { long __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  X2.Add(__v0); }   }
            { var __json0 = _buf["x3"]; if(!__json0.IsArray) { throw new SerializationException(); } X3 = new System.Collections.Generic.List<string>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { string __v0;  { if(!__e0.IsString) { throw new SerializationException(); }  __v0 = __e0; }  X3.Add(__v0); }   }
            { var __json0 = _buf["x4"]; if(!__json0.IsArray) { throw new SerializationException(); } X4 = new System.Collections.Generic.List<test.DemoEnum>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { test.DemoEnum __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = (test.DemoEnum)__e0.AsInt; }  X4.Add(__v0); }   }
        }
    
        public static TestSet DeserializeTestSet(JSONNode _buf)
        {
            return new test.TestSet(_buf);
        }
    
        public readonly int Id;
        public readonly string X0;
        public readonly System.Collections.Generic.List<int> X1;
        public readonly System.Collections.Generic.List<long> X2;
        public readonly System.Collections.Generic.List<string> X3;
        public readonly System.Collections.Generic.List<test.DemoEnum> X4;
       
        public const int __ID__ = -543221516;
        public override int GetTypeId() => __ID__;
    
        public  void ResolveRef(Tables tables)
        {
            
            
            
            
            
            
        }
    
        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "x0:" + X0 + ","
            + "x1:" + StringUtil.CollectionToString(X1) + ","
            + "x2:" + StringUtil.CollectionToString(X2) + ","
            + "x3:" + StringUtil.CollectionToString(X3) + ","
            + "x4:" + StringUtil.CollectionToString(X4) + ","
            + "}";
        }
    }

}
