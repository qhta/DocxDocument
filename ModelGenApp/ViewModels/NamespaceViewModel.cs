namespace ModelGenApp.ViewModels;
public class NamespaceViewModel : ViewModel<Namespace>
{
  public NamespaceViewModel(PhaseViewModel phaseViewModel, Namespace ns, string? filter) : base(ns)
  {
    Phase = phaseViewModel;
    Filter = filter;
    Name = ns.OrigName;
    if (phaseViewModel.Phase == PPS.RenameTypes)
      TargetName = ns.TargetName;
    AllTypes = new TypeListViewModel(this, "All types", phaseViewModel.NamespaceTypeSelector, TKS.Any);
    Classes = new ClassListViewModel(this, "Classes", phaseViewModel.NamespaceTypeSelector, TKS.Class);
    Enums = new EnumTypeListViewModel(this, "Enums", phaseViewModel.NamespaceTypeSelector, TKS.Enum);
    Interfaces = new ClassListViewModel(this, "Interfaces", phaseViewModel.NamespaceTypeSelector, TKS.Interface);
    Structs = new ClassListViewModel(this, "Structs", phaseViewModel.NamespaceTypeSelector, TKS.Struct);
    Others = new TypeListViewModel(this, "Others", phaseViewModel.NamespaceTypeSelector, TKS.Other);
  }

  public PhaseViewModel Phase { get; private set; }

  public string? Filter { get; private set; }

  public string Name { get; set; }

  public string? TargetName { get; set; }

  public string Caption => Phase.PhaseName + " " + this.Name;



  [DataGridColumn(ResourceDataTemplateKey = "ItemsCountColumnTemplate",
    SortMemberPath = "AllTypes.Count", ClipboardContentPath = "AllTypes.Count")]
  public TypeListViewModel AllTypes { get; set; }

  [DataGridColumn(ResourceDataTemplateKey = "ItemsCountColumnTemplate",
    SortMemberPath = "Classes.Count", ClipboardContentPath = "Classes.Count")]
  public TypeListViewModel Classes { get; set; }

  [DataGridColumn(ResourceDataTemplateKey = "ItemsCountColumnTemplate",
    SortMemberPath = "Enums.Count", ClipboardContentPath = "Enums.Count")]
  public TypeListViewModel Enums { get; set; }

  [DataGridColumn(ResourceDataTemplateKey = "ItemsCountColumnTemplate",
    SortMemberPath = "Interfaces.Count", ClipboardContentPath = "Interfaces.Count")]
  public TypeListViewModel Interfaces { get; set; }

  [DataGridColumn(ResourceDataTemplateKey = "ItemsCountColumnTemplate",
    SortMemberPath = "Structs.Count", ClipboardContentPath = "Structs.Count")]
  public TypeListViewModel Structs { get; set; }

  [DataGridColumn(ResourceDataTemplateKey = "ItemsCountColumnTemplate",
    SortMemberPath = "Others.Count", ClipboardContentPath = "Others.Count")]
  public TypeListViewModel Others { get; set; }

  public async void GetTypes()
  {
    await Task.Run(()=>{
    var nsTypes = Model.Types.OrderBy(item => item.Name).ToList();
    var filter = Filter;
    if (filter != null)
    {
      if (filter == SummaryInfoKind.AcceptedTypes.ToString())
        nsTypes = nsTypes.Where(item => item.IsAccepted).ToList();
      if (filter == SummaryInfoKind.RejectedTypes.ToString())
        nsTypes = nsTypes.Where(item => item.IsRejected).ToList();
      if (filter == SummaryInfoKind.InvalidTypes.ToString())
        nsTypes = nsTypes.Where(item => item.IsInvalid).ToList();
      if (filter == SummaryInfoKind.RenamedTypes.ToString())
        nsTypes = nsTypes.Where(item => item.IsRenamed).ToList();
    }
    var nts = Phase.NamespaceTypeSelector;
    var nsTypesVM = nsTypes.Select(item => new TypeInfoViewModel(item, nts.HasFlag(NTS.Origin))).ToList();
    AllTypes.Items.AddRange(nsTypesVM);
    var nsClassesVM = nsTypes.Where(item => item.TypeKind == TypeKind.Class)
      .Select(item => new ClassInfoViewModel(item, nts.HasFlag(NTS.Origin))).ToList();
    Classes.Items.AddRange(nsClassesVM);
    var nsEnumsVM = nsTypes.Where(item => item.TypeKind == TypeKind.Enum)
      .Select(item => new EnumTypeInfoViewModel(item, nts.HasFlag(NTS.Origin))).ToList();
    Enums.Items.AddRange(nsEnumsVM);
    var nsInterfacesVM = nsTypes.Where(item => item.TypeKind == TypeKind.Interface)
      .Select(item => new ClassInfoViewModel(item, nts.HasFlag(NTS.Origin))).ToList();
    Interfaces.Items.AddRange(nsInterfacesVM);
    var nsStructsVM = nsTypes.Where(item => item.TypeKind == TypeKind.Struct)
      .Select(item => new ClassInfoViewModel(item, nts.HasFlag(NTS.Origin))).ToList();
    Structs.Items.AddRange(nsStructsVM);
    var nsOthersVM = nsTypesVM.Where(item => item.TypeKind == TypeKind.Type).ToList();
    Others.Items.AddRange(nsOthersVM);
    });
  }
}
