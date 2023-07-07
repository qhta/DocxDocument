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
        if (configData.NamespaceShortcuts.TryGetValue(ns, out var shortcut))
          item.Shortcut = shortcut;
        if (configData.TranslatedNamespaces.TryGetValue(ns, out var translated))
          item.TranslatedName = translated;
        if (translated != null)
          if (configData.NamespaceShortcuts.TryGetValue(translated, out var shortcut2))
            item.TranslatedShortcut = shortcut2;
        Add(item);
      }
    }
  }

  public void SetData(ModelConfig configData)
  {
    configData.IncludedNamespaces.Clear();
    configData.ExcludedNamespaces.Clear();
    configData.NamespaceShortcuts.Clear();
    configData.TranslatedNamespaces.Clear();
    foreach (var item in Items)
    {
      if (item.Included)
        configData.IncludedNamespaces.Add(item.Name);
      if (item.Excluded)
        configData.ExcludedNamespaces.Add(item.Name);
      if (!String.IsNullOrWhiteSpace(item.Shortcut))
        configData.NamespaceShortcuts.Add(item.Name, item.Shortcut);
      if (!String.IsNullOrWhiteSpace(item.TranslatedName))
        configData.TranslatedNamespaces.Add(item.Name, item.TranslatedName);
      if (!String.IsNullOrEmpty(item.TranslatedShortcut) && !String.IsNullOrWhiteSpace(item.TranslatedName))
      {
        if (!configData.NamespaceShortcuts.TryGetValue2(item.TranslatedName, out _))
          configData.NamespaceShortcuts.Add(item.TranslatedName, item.TranslatedShortcut);
      }
    }
  }

  public bool ValidateData(ModelConfig configData)
  {
    var ok = true;
    var knownShortcuts = new List<string>();
    foreach (var item in Items)
    {
      bool isValid = true;
      string? validationMsg = null;
      if (!String.IsNullOrWhiteSpace(item.Shortcut))
      {
        if (knownShortcuts.Contains(item.Shortcut))
        {
          isValid = false;
          validationMsg = "Duplicated shortcut";
        }
        knownShortcuts.Add(item.Shortcut);
      }
      item.IsValid = isValid;
      item.ValidationMsg = validationMsg;
      if (!isValid)
        ok = false;
    }
    return ok;
  }
}
