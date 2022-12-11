using System.Collections.Generic;

namespace ModelGen;

public class QualifiedName
{
  public QualifiedName(string fullName)
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

  public QualifiedName(string name, string? nspace)
  {
    Name = name;
    Namespace = nspace;
  }
  public string Name { get; set; }
  public string? Namespace { get; set; }

  public List<QualifiedName>? ArgNames { get; set; }

  public string FullName
  {
    get
    {
      string name;
      if (ArgNames == null)

        name = Name;
      else
      {
        List<string> ls = new List<string>();
        foreach (var arg in ArgNames)
          ls.Add(arg.FullName);
        name = Name + "<" + String.Join(", ", ls) + ">";
      }
      if (string.IsNullOrEmpty(Namespace))
        return name;
      return Namespace + "." + name;  
    }
  }

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

  //public void TrimNamespace(string nspace)
  //{
  //  if (Namespace != null)
  //  {
  //    var thisNsSegments = Namespace.Split('.').ToList();
  //    var nspaceSegments = nspace.Split(".");
  //    int k;
  //    for (k=0; k < thisNsSegments.Count() && k < nspaceSegments.Count(); k++)
  //    {
  //      if (thisNsSegments[k] != nspaceSegments[k])
  //        break;
  //    }
  //    if (k > 0)
  //    {
  //      nspace = string.Empty;
  //      for (int i = k; i < thisNsSegments.Count(); i++)
  //      {
  //        if (nspace != string.Empty)
  //          nspace += ".";
  //        nspace = thisNsSegments[i];
  //      }
  //      Namespace = nspace;
  //    }
  //  }
  //  if (ArgNames != null)
  //    foreach (var arg in ArgNames)
  //      arg.TrimNamespace(nspace);
  //}


  public override string ToString()
  {
    return FullName;
  }

}