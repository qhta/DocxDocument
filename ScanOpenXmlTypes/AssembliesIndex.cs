using OpenXmlDatabase.Models;

namespace ScanOpenXmlTypes;

public class AssembliesIndex: Dictionary<string, Assembly>
{
  public AssembliesIndex(IEnumerable<Assembly> assemblies)
  {
    foreach (var ns in assemblies)
    {
      Add(ns.Name!, ns);
    }
  }
}
