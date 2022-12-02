using System.Collections.Generic;

namespace ModelGen;

public class CompoundName
{
  public CompoundName(string name, string? nspace = null)
  {
    Name = name;
    Namespace = nspace;
  }
  public string Name { get; set; }
  public string? Namespace { get; set; }

  public List<CompoundName>? ArgNames { get; set; }

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

  public override string ToString()
  {
    return FullName;
  }

}