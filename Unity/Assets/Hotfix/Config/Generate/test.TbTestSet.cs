
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
    public partial class TbTestSet
    {
        private readonly System.Collections.Generic.Dictionary<int, test.TestSet> _dataMap;
        private readonly System.Collections.Generic.List<test.TestSet> _dataList;
        
        public TbTestSet(JSONNode jsonNode)
        {
            _dataMap = new System.Collections.Generic.Dictionary<int, test.TestSet>();
            _dataList = new System.Collections.Generic.List<test.TestSet>();
            
            foreach(JSONNode vNode in jsonNode.Children)
            {
                test.TestSet deserializeItem;
                { if(!vNode.IsObject) { throw new SerializationException(); }  deserializeItem = test.TestSet.DeserializeTestSet(vNode);  }
                _dataList.Add(deserializeItem);
                _dataMap.Add(deserializeItem.Id, deserializeItem);
            }
        }
    
        public System.Collections.Generic.Dictionary<int, test.TestSet> DataMap 
        {
            get { return _dataMap; }
        }

        public System.Collections.Generic.List<test.TestSet> DataList 
        {
            get { return _dataList; }
        }
    
        public test.TestSet GetOrDefault(int key) 
        {  
            return _dataMap.TryGetValue(key, out var v) ? v : null;
        }
        
        public test.TestSet Get(int key) 
        { 
            return _dataMap[key];
        }
        
        public test.TestSet this[int key] 
        {
            get
            {
                return _dataMap[key];
            }
        }
    
        public void ResolveRef(Tables tables)
        {
            foreach(var value in _dataList)
            {
                value.ResolveRef(tables);
            }
        }
        
    }

}
