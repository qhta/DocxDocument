using System.Reflection;

namespace ModelGenDataConfig;
public class AssemblyNames: SortedSet<string>
{
  public bool Contains(AssemblyName aName)
  {
    var sName = aName.ToString();
    if (base.Contains(sName)) return true;
    aName = new AssemblyName{ Name = aName.Name, Version = aName.Version, CultureName=aName.CultureName };
    sName = aName.ToString();
    if (base.Contains(sName)) return true;
    aName = new AssemblyName{ Name = aName.Name, Version = aName.Version};
    sName = aName.ToString();
    if (base.Contains(sName)) return true;
    aName = new AssemblyName{ Name = aName.Name};
    sName = aName.ToString();
    if (base.Contains(sName)) return true;
    return false;
  }

}
