namespace ModelGenApp.ViewModels;
public class NamespaceConfigListViewModel : ConfigListViewModel
{
  public NamespaceConfigListViewModel(ModelConfigViewModel owner): base(owner)
  {
    Caption = CommonStrings.ModelConfiguration + " | " + CommonStrings.Namespaces.ToLower();
    Items = new ListViewModel<NamespaceConfigViewModel>();
    CollectionViewSource = new CollectionViewSource<NamespaceConfigViewModel>(Items);
    VisibleItems = CollectionViewSource.GetDefaultView(Items);
    //VisibleItems.Filter = new Predicate<object>(item => item is NamespaceConfigViewModel viewModel && viewModel.OrigName.Contains("Wordprocessing"));
  }

  public ListViewModel<NamespaceConfigViewModel> Items { [DebuggerStepThrough] get; private set; }

  private CollectionViewSource<NamespaceConfigViewModel> CollectionViewSource;

  /// <summary>
  /// This is the result collection view to be used in DataGrid.
  /// </summary>
  public ICollectionView VisibleItems { [DebuggerStepThrough] get; private set; }

  public void ClearItems()
  {
    Items.Clear();
    nsCount = 0;
  }

  int nsCount = 0; 


  public void CreateItems(ModelConfigData configData)
  {
    foreach (var ns in Owner.LoadedNamespaces)
    {
      var item = new NamespaceConfigViewModel { OrigName = ns };
      item.RecordNumber = ++nsCount;
      item.Types = Owner.LoadedTypes.Where(item=>item.Namespace==ns).ToArray();
      item.IsIncluded = configData.IncludedNamespaces.Contains(ns);
      item.IsExcluded = configData.ExcludedNamespaces.Contains(ns);
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
      Items.Add(item);
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
    configData.IncludedNamespaces.Clear();
    configData.ExcludedNamespaces.Clear();
    configData.NamespaceShortcuts.Clear();
    configData.TranslatedNamespaces.Clear();
    foreach (var item in Items)
    {
      if (item.IsIncluded)
        configData.IncludedNamespaces.Add(item.OrigName);
      if (item.IsExcluded)
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
    foreach (var item in Items)
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
    foreach (var item in Items)
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
    foreach (var ns in Items)
    {
      ns.HasUniqueTypes = true;
      ns.DuplicatedTypes.Clear();
    }
    var ok = true;
    var knownTargetNamespaces = new Dictionary<string, Dictionary<string, Type>>(); // target namespaces with typenames
    foreach (var newNamespace in Items)
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
              var oldNamespace = Items.First(ns => ns.OrigName == oldType.Namespace);
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

  public bool AreAllShortcutsValid => Items.Any(item => !item.IsShortcutValid);

  public bool AreAllTargetShortcutsValid => Items.Any(item => !item.IsTargetShortcutValid);

  public bool AreAllTypesUnique => Items.Any(item => !item.HasUniqueTypes);
}
