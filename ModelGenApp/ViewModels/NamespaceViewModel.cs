﻿namespace ModelGenApp.ViewModels;
public class NamespaceViewModel : ViewModel<Namespace>
{
  public NamespaceViewModel(PhaseResultsViewModel phaseViewModel, Namespace ns, TypeInfoViewModelFilter? filter = null) : base(ns)
  {

    Phase = phaseViewModel;
    Filter = filter;
    Name = ns.Name;
    TargetName = ns.TargetName;
    AllTypes = new TypeListViewModel(phaseViewModel, this, ns.Name+":AllTypes", phaseViewModel.TypeNameSelector, TKS.Any, Filter);
    Classes = new ClassListViewModel(phaseViewModel, this, ns.Name+":ClassTypes", phaseViewModel.TypeNameSelector, TKS.Class, Filter, AllTypes);
    Enums = new EnumTypeListViewModel(phaseViewModel, this, ns.Name+":EnumTypes", phaseViewModel.TypeNameSelector, TKS.Enum, Filter, AllTypes);
    Interfaces = new ClassListViewModel(phaseViewModel, this, ns.Name+":InterfaceTypes", phaseViewModel.TypeNameSelector, TKS.Interface, Filter, AllTypes);
    Structs = new ClassListViewModel(phaseViewModel, this, ns.Name+":StructTypes", phaseViewModel.TypeNameSelector, TKS.Struct, Filter, AllTypes);
    Others = new TypeListViewModel(phaseViewModel, this, ns.Name+":OtherTypes", phaseViewModel.TypeNameSelector, TKS.Other, Filter, AllTypes);
  }

  public PhaseResultsViewModel Phase { [DebuggerStepThrough] get; private set; }

  public string PhaseName => Phase.PhaseName;

    public TypeInfoViewModelFilter? Filter
  {
   [DebuggerStepThrough] get { return _Filter; }
    set
    {
      if (_Filter != value)
      {
        _Filter = value;
        NotifyPropertyChanged(nameof(Filter));
        ApplyFilter();
      }
    }
  }
  private TypeInfoViewModelFilter? _Filter;

  public void ApplyFilter()
  {
    if (AllTypes==null)
      return;
    AllTypes.Filter = Filter;
    Classes.Filter = Filter;
    Enums.Filter = Filter;
    Interfaces.Filter = Filter;
    Structs.Filter = Filter;
    Others.Filter = Filter;
  }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Name),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.OriginalNamespaceTooltip)
    )]
  public string Name { [DebuggerStepThrough] get; set; }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.TargetName),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.TargetNamespaceTooltip)
    )]
  public string? TargetName { [DebuggerStepThrough] get; set; }

  public string Caption
  {
    get
    {
      var result = CommonStrings.ResourceManager.GetString(PhaseName, CultureInfo.CurrentUICulture) ?? PhaseName
                             + " " + CommonStrings.ResourceManager.GetString(Name, CultureInfo.CurrentUICulture) ?? Name;
      if (Filter != null)
        result += " | " + Filter.Caption;
      return result;
    }
  }


  const int minColWith = 80;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.All),
    MinWidth = minColWith,
    DataTemplateResourceKey = "CountColumnTemplate",
    SortMemberPath = "AllTypes.Count",
    ClipboardContentPath = "AllTypes.Count")]
  public TypeListViewModel AllTypes { [DebuggerStepThrough] get; set; }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Classes),
    MinWidth = minColWith,
    DataTemplateResourceKey = "CountColumnTemplate",
    SortMemberPath = "Classes.Count",
    ClipboardContentPath = "Classes.Count")]
  public ClassListViewModel Classes { [DebuggerStepThrough] get; set; }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Enums),
    MinWidth = minColWith,
    DataTemplateResourceKey = "CountColumnTemplate",
    SortMemberPath = "Enums.Count",
    ClipboardContentPath = "Enums.Count")]
  public EnumTypeListViewModel Enums { [DebuggerStepThrough] get; set; }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Interfaces),
    MinWidth = minColWith,
    DataTemplateResourceKey = "CountColumnTemplate",
    SortMemberPath = "Interfaces.Count",
    ClipboardContentPath = "Interfaces.Count")]
  public ClassListViewModel Interfaces { [DebuggerStepThrough] get; set; }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Structs),
    MinWidth = minColWith,
    DataTemplateResourceKey = "CountColumnTemplate",
    SortMemberPath = "Structs.Count",
    ClipboardContentPath = "Structs.Count")]
  public ClassListViewModel Structs { [DebuggerStepThrough] get; set; }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Others),
    MinWidth = minColWith,
    DataTemplateResourceKey = "CountColumnTemplate",
    SortMemberPath = "Others.Count",
    ClipboardContentPath = "Others.Count")]
  public TypeListViewModel Others { [DebuggerStepThrough] get; set; }

  public async void FillTypesAsync()
  {
    await Task.Factory.StartNew(() => FillTypes());
  }

  public void FillTypes()
  {
    AllTypes.FillItems();
    Classes.FillItems();
    Enums.FillItems();
    Interfaces.FillItems();
    Structs.FillItems();
    Others.FillItems();
  }

  public async void RefreshAsync()
  {
    await Task.Factory.StartNew(() => Refresh());
  }

  public void Refresh()
  {
    lock (Model.Types)
    {
      AllTypes.RefreshItemsAsync();
      Classes.RefreshItemsAsync();
      Enums.RefreshItemsAsync();
      Interfaces.RefreshItemsAsync();
      Structs.RefreshItemsAsync();
      Others.RefreshItemsAsync();
    }
  }

}
