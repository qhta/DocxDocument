using Qhta.TextUtils;

namespace ModelGen;

public class FullTypeName
{
  public FullTypeName(string fullName)
  {
    var k = fullName.LastIndexOf(".");
    if (k > 0 && k<fullName.Length-1)
    {
      Namespace = fullName.Substring(0, k);
      Name = fullName.Substring(k+1);
    }
    else
    {
      Name = fullName;
      Namespace = null;
    }
  }

  public FullTypeName(string name, string? nspace)
  {
    Name = name;
    Namespace = nspace;
  }
  public string Name { get; set; }
  public string? Namespace { get; set; }

  public List<FullTypeName>? ArgNames { get; set; }

  public string[] GetNamespaces()
  {
    List <string> namespaces = new List<string>();
    if (Namespace!= null)
      namespaces.Add(Namespace);
    if (ArgNames != null)
      foreach (var arg in ArgNames)
        namespaces.AddRange(arg.GetNamespaces());
    return namespaces.ToArray();
  }

  public void RemoveNamespace(string nspace)
  {
    if (nspace == Namespace)
      Namespace = null;
    if (ArgNames != null)
      foreach (var arg in ArgNames)
        arg.RemoveNamespace(nspace);
  }

  public void TrimNamespace(string nspace)
  {
    if (Namespace != null)
    {
      //  var thisNsSegments = Namespace.Split('.').ToList();
      //  var nspaceSegments = nspace.Split(".");
      //  int k;
      //  for (k = 0; k < thisNsSegments.Count() && k < nspaceSegments.Count(); k++)
      //  {
      //    if (thisNsSegments[k] != nspaceSegments[k])
      //      break;
      //  }
      //  if (k > 0)
      //  {
      //    nspace = string.Empty;
      //    for (int i = k; i < thisNsSegments.Count(); i++)
      //    {
      //      if (nspace != string.Empty)
      //        nspace += ".";
      //      nspace = thisNsSegments[i];
      //    }
      //    Namespace = nspace;
      //  }
      //}
      if (!nspace.EndsWith('.'))
        nspace = nspace + ".";
      if (Namespace.StartsWith(nspace))
        Namespace = Namespace.Substring(nspace.Length);
      if (ArgNames != null)
        foreach (var arg in ArgNames)
          arg.TrimNamespace(nspace);
    }
  }


  public override string ToString()
  {
    string name;
    if (ArgNames == null)

      name = Name;
    else
    {
      List<string> ls = new List<string>();
      foreach (var arg in ArgNames)
        ls.Add(arg.ToString());
      name = Name + "<" + String.Join(", ", ls) + ">";
    }
    if (string.IsNullOrEmpty(Namespace))
      return name;
    return Namespace + "." + name;
  }

  public static FullTypeName Parse(string str)
  {
    int k;
    FullTypeName result = null!;
    var argNames = new List<FullTypeName>();
    if (str.EndsWith('>'))
    {
      k = str.IndexOf('<');
      if (k >= 0)
      {
        var argStr = str.Substring(k + 1, str.Length - k - 1);
        str = str.Substring(0, k);
        var strs = argStr.SplitSpecial('.', new (char Open, char Close)[] { ('<', '>') });
        foreach (var s in strs)
          argNames.Add(Parse(s));
      }
    }

    k = str.LastIndexOf('.');
    if (k >= 0)
      result = new FullTypeName(str.Substring(k+1), str.Substring(0,k));
    else
      result = new FullTypeName(str, null);
    if (argNames.Count > 0)
      result.ArgNames = argNames;
    return result;
  }

  public static implicit operator string(FullTypeName value) => value.ToString();
  public static implicit operator FullTypeName (string value) => FullTypeName.Parse(value);
}