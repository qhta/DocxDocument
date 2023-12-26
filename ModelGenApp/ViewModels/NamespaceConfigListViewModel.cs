namespace ModelGenApp.ViewModels;
public class NamespaceConfigListViewModel : ModelConfigViewModel
{
  public NamespaceConfigListViewModel(ModelConfigData configData) : base(configData)
  {
    Caption = CommonStrings.ModelConfiguration + " | " + CommonStrings.Namespaces.ToLower();
    Namespaces = new ListViewModel<NamespaceConfigViewModel>();
    VisibleItems = new CollectionViewSource<NamespaceConfigViewModel>(Namespaces);
    //VisibleItems = CollectionViewSource.GetDefaultView(Namespaces);
    //VisibleItems.Filter = new Predicate<object>(item => item is NamespaceConfigViewModel viewModel && viewModel.OrigName.Contains("Wordprocessing"));
    GetData(configData);
  }

  public ListViewModel<NamespaceConfigViewModel> Namespaces { get; private set; }

  public CollectionViewSource<NamespaceConfigViewModel> VisibleItems { get; private set; }

  /// <summary>
  /// This is the result collection view to be used in DataGrid.
  /// </summary>
  //public ICollectionView VisibleItems { get; private set; }

  public override void GetData(ModelConfigData configData)
  {
    Namespaces.Clear();
    base.GetData(configData);
    if (_Assembly != null)
    {
      var namespaces = _Assembly.GetExportedTypes()
        .Where(type => !type.IsConstructedGenericType)
        .GroupBy(item => item.Namespace)
        .OrderBy(grp => grp.Key)
        .ToList();
      foreach (var group in namespaces)
      {
        if (group.Key != null)
        {
          var ns = group.Key;
          var item = new NamespaceConfigViewModel { OrigName = ns };
          item.Types = group.ToArray();
          item.Excluded = configData.ExcludedNamespaces.Contains(ns);
          if (configData.NamespaceShortcuts.TryGetValue(ns, out var shortcut))
            item.Shortcut = shortcut;
          if (configData.TranslatedNamespaces.TryGetValue(ns, out var translated))
          {
            item.TargetName = translated;
            item.TargetExcluded = configData.ExcludedNamespaces.Contains(translated);
          }
          if (translated != null)
            if (configData.NamespaceShortcuts.TryGetValue(translated, out var targetShortcut))
              item.TargetShortcut = targetShortcut;
          item.PropertyChanged += Item_PropertyChanged;
          Namespaces.Add(item);
        }
      }
    }
    ValidateData();
  }

  private void Item_PropertyChanged(object? sender, PropertyChangedEventArgs e)
  {
    if (e.PropertyName == nameof(NamespaceConfigViewModel.Shortcut)
      || e.PropertyName == nameof(NamespaceConfigViewModel.TargetShortcut)
      || e.PropertyName == nameof(NamespaceConfigViewModel.TargetName))
      ValidateData();
  }

  public override void SetData(ModelConfigData configData)
  {
    configData.ExcludedNamespaces.Clear();
    configData.NamespaceShortcuts.Clear();
    configData.TranslatedNamespaces.Clear();
    foreach (var item in Namespaces)
    {
      if (item.Excluded)
        configData.ExcludedNamespaces.Add(item.OrigName);
      if (item.TargetExcluded && item.TargetName != null)
        configData.ExcludedNamespaces.Add(item.TargetName);
      if (!String.IsNullOrWhiteSpace(item.Shortcut))
        configData.NamespaceShortcuts.Add(item.OrigName, item.Shortcut);
      if (!String.IsNullOrWhiteSpace(item.TargetName))
        configData.TranslatedNamespaces.Add(item.OrigName, item.TargetName);
      if (!String.IsNullOrEmpty(item.TargetShortcut) && !String.IsNullOrWhiteSpace(item.TargetName))
      {
        if (!configData.NamespaceShortcuts.TryGetValue2(item.TargetName, out _))
          configData.NamespaceShortcuts.Add(item.TargetName, item.TargetShortcut);
      }
    }
  }

  public override bool ValidateData()
  {
    var ok = true;
    if (!ValidateShortcuts())
      ok = false;
    if (!ValidateTargetShortcuts())
      ok = false;
    if (!ValidateUniqueTypes())
      ok = false;
    NotifyPropertyChanged(nameof(AreAllShortcutsValid));
    NotifyPropertyChanged(nameof(AreAllTargetShortcutsValid));
    NotifyPropertyChanged(nameof(AreAllTypesUnique));
    return ok;
  }

  public bool ValidateShortcuts()
  {
    var ok = true;
    // Names are unique, so we must check only if a shortcut already exists.
    var knownShortcuts = new List<string>();
    foreach (var item in Namespaces)
    {
      bool isValid = true;
      if (!String.IsNullOrWhiteSpace(item.Shortcut))
      {
        if (knownShortcuts.Contains(item.Shortcut))
        {
          isValid = false;
        }
        else
          knownShortcuts.Add(item.Shortcut);
      }
      item.IsShortcutValid = isValid;
      if (!isValid)
        ok = false;
    }
    return ok;
  }

  public bool ValidateTargetShortcuts()
  {
    var ok = true;
    // Target names are not unique, so we must check if a target shortcut already exists with a different target name.
    var knownTargetShortcuts = new Dictionary<string, string?>();  // target shortcut to target name mapping
    // We must also check if a target name already is mapped to different target shortcut
    var knownTargetNames = new Dictionary<string, string?>(); // target name to target shortcut mapping
    foreach (var item in Namespaces)
    {
      bool isValid = true;
      if (!String.IsNullOrWhiteSpace(item.TargetShortcut))
      {
        if (knownTargetShortcuts.TryGetValue(item.TargetShortcut, out var targetName))
        {
          if (targetName != item.TargetName)
          {
            isValid = false;
          }
        }
        else
          knownTargetShortcuts.Add(item.TargetShortcut, item.TargetName);
      }
      if (!String.IsNullOrWhiteSpace(item.TargetName))
      {
        if (knownTargetNames.TryGetValue(item.TargetName, out var targetShortcut))
        {
          if (targetShortcut != item.TargetShortcut)
          {
            isValid = false;
          }
        }
        else
          knownTargetNames.Add(item.TargetName, item.TargetShortcut);
      }
      item.IsTargetShortcutValid = isValid;
      if (!isValid)
        ok = false;
    }
    return ok;
  }

  /// <summary>
  /// Checks whether target namespace of different original namespaces does not contain duplicated type names.
  /// </summary>
  /// <returns></returns>
  public bool ValidateUniqueTypes()
  {
    foreach (var ns in Namespaces)
    {
      ns.HasUniqueTypes = true;
      ns.DuplicatedTypes.Clear();
    }
    var ok = true;
    var knownTargetNamespaces = new Dictionary<string, Dictionary<string, Type>>(); // target namespaces with typenames
    foreach (var newNamespace in Namespaces)
    {
      if (!String.IsNullOrWhiteSpace(newNamespace.TargetName))
      {
        if (!knownTargetNamespaces.TryGetValue(newNamespace.TargetName, out var targetTypes))
        {
          targetTypes = new Dictionary<string, Type>(newNamespace.Types.ToDictionary(type => type.Name));
          knownTargetNamespaces.Add(newNamespace.TargetName, targetTypes);
        }
        else
        {
          var newTargetTypes = newNamespace.Types;
          foreach (var newType in newTargetTypes)
          {
            if (targetTypes.TryGetValue(newType.Name, out var oldType))
            {
              var oldNamespace = Namespaces.First(ns => ns.OrigName == oldType.Namespace);
              oldNamespace.HasUniqueTypes = false;
              if (!oldNamespace.DuplicatedTypes.ContainsKey(oldType.Name))
                oldNamespace.DuplicatedTypes.Add(oldType.Name, oldType);
              newNamespace.HasUniqueTypes = false;
              if (!newNamespace.DuplicatedTypes.ContainsKey(newType.Name))
                newNamespace.DuplicatedTypes.Add(newType.Name, newType);
              ok = false;
            }
            else
              targetTypes.Add(newType.Name, newType);
          }
        }
      }
    }
    return ok;
  }

  public bool AreAllShortcutsValid => Namespaces.Any(item => !item.IsShortcutValid);

  public bool AreAllTargetShortcutsValid => Namespaces.Any(item => !item.IsTargetShortcutValid);

  public bool AreAllTypesUnique => Namespaces.Any(item => !item.HasUniqueTypes);
}
