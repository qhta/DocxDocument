using System.Buffers;
using System.Diagnostics;

namespace ModelGen;

public class Namespace
{
  public string OrigName { get; private set; }

  public string? TargetName { get; set; }

  public OwnedCollection<TypeInfo> Types { get; private set; }

  //private class TypeInfoComparer : IEqualityComparer<TypeInfo>
  //{
  //  public int Compare(TypeInfo? x, TypeInfo? y)
  //  {
  //    if (x == null || y == null)
  //      return 0;
  //    var xName = x.Name;
  //    var yName = y.Name;
  //    var result = xName.CompareTo(yName);
  //    Debug.Assert(result != 0);
  //    return result;
  //  }

  //  public bool Equals(TypeInfo? x, TypeInfo? y)
  //  {
  //    return false;
  //  }

  //  public int GetHashCode(TypeInfo obj)
  //  {
  //    return obj.GetHashCode();
  //  }
  //}



  //private static TypeInfoComparer MyComparer = new TypeInfoComparer();

  /// <summary>
  /// 
  /// </summary>
  public Namespace(string name)
  {
    OrigName = name;
    Types = new OwnedCollection<TypeInfo>(this);
  }

  //public void Add(TypeInfo typeInfo)
  //{
  //  var name = typeInfo.GetNameWithParams();
  //  Add(name, typeInfo);
  //}

  public bool TryGetTypesWithSameName(TypeInfo typeInfo, out IEnumerable<TypeInfo> types)
  {
    var name = typeInfo.GetNameWithParams();
    types = Types.Where(item => item.GetNameWithParams() == name).ToList();
    return types.Count() > 0;
  }
}