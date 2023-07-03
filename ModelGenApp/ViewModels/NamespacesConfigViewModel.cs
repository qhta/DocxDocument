namespace ModelGenApp.ViewModels;
public class NamespacesConfigViewModel : DispatchedCollection<NamespaceConfigViewModel>
{
  public void GetData(ModelConfig configData, Assembly assembly)
  {
    var nsNames = assembly.GetExportedTypes()
      .Select(t => t.Namespace)
      .GroupBy(ns => ns)
      .Select(grp => grp.Key)
      .OrderBy(name => name)
      .ToList();
    foreach (var ns in nsNames)
    {
      if (ns != null)
      {

        var item = new NamespaceConfigViewModel { Name = ns };
        item.Excluded = configData.ExcludedNamespaces.Contains(ns);
        item.Included = configData.IncludedNamespaces.Contains(ns);
        if (configData.NamespacePrefixes.TryGetValue(ns, out var prefix))
          item.Prefix = prefix;
        if (configData.TranslatedNamespaces.TryGetValue(ns, out var translated))
          item.TranslatedName = translated;
        Add(item);
      }
    }
  }

  public void SetData(ModelConfig configData)
  {
    configData.IncludedNamespaces.Clear();
    configData.ExcludedNamespaces.Clear();
    foreach (var item in Items)
    {
      if (item.Included)
        configData.IncludedNamespaces.Add(item.Name);
      if (item.Excluded)
        configData.ExcludedNamespaces.Add(item.Name);
    }
  }
}
