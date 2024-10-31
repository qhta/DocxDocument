using OpenXmlDatabase.Models;

namespace ScanOpenXmlTypes;

public class NamespacesIndex: Dictionary<string, Namespace>
{
  public NamespacesIndex(IEnumerable<Namespace> namespaces)
  {
    foreach (var ns in namespaces)
    {
      Add(ns.Name!, ns);
    }
  }
}
