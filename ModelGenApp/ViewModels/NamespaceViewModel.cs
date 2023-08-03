namespace ModelGenApp.ViewModels;
public class NamespaceViewModel : ViewModel<Namespace>
{
  public NamespaceViewModel(PhaseViewModel phaseViewModel, Namespace ns, string? filter = null) : base(ns)
  {
    Phase = phaseViewModel;
    Filter = filter;
    Name = ns.OriginalName;
    if (phaseViewModel.PhaseNum == PPS.RenameTypes)
      TargetName = ns.TargetName;
    AllTypes = new TypeListViewModel(phaseViewModel, this, "All types", phaseViewModel.NameKindSelector, TKS.Any);
    Classes = new ClassListViewModel(phaseViewModel, this, "Classes", phaseViewModel.NameKindSelector, TKS.Class);
    Enums = new EnumTypeListViewModel(phaseViewModel, this, "Enums", phaseViewModel.NameKindSelector, TKS.Enum);
    Interfaces = new ClassListViewModel(phaseViewModel, this, "Interfaces", phaseViewModel.NameKindSelector, TKS.Interface);
    Structs = new ClassListViewModel(phaseViewModel, this, "Structs", phaseViewModel.NameKindSelector, TKS.Struct);
    Others = new TypeListViewModel(phaseViewModel, this, "Others", phaseViewModel.NameKindSelector, TKS.Other);
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

  public async void LoadTypesAsync()
  {
    await Task.Run(() => LoadTypes());
  }

  public void LoadTypes()
  {
    var types = Model.Types.OrderBy(item => item.Name).ToList();
    var filter = Filter;
    if (filter != null)
    {
      if (filter == SummaryInfoKind.AcceptedTypes.ToString())
        types = types.Where(item => item.IsAcceptedAfter(Phase.PhaseNum)).ToList();
      if (filter == SummaryInfoKind.RejectedTypes.ToString())
        types = types.Where(item => item.IsRejectedAfter(Phase.PhaseNum)).ToList();
      if (filter == SummaryInfoKind.InvalidTypes.ToString())
        types = types.Where(item => !item.IsValid(Phase.PhaseNum)).ToList();
      if (filter == SummaryInfoKind.RenamedTypes.ToString())
        types = types.Where(item => item.IsRenamed).ToList();
      if (filter == SummaryInfoKind.ConvertedTypes.ToString())
        types = types.Where(item => item.IsConverted).ToList();
    }
    var nts = Phase.NamespaceTypeSelector;
    AllTypes.CreateItems(types);
    Classes.FilterItems(AllTypes.Types);
    Enums.FilterItems(AllTypes.Types);
    Interfaces.FilterItems(AllTypes.Types);
    Structs.FilterItems(AllTypes.Types);
    Others.FilterItems(AllTypes.Types);
  }

}
