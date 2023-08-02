namespace ModelGenApp.ViewModels;
public class RenamePhaseViewModel : PhaseViewModel
{
  public RenamePhaseViewModel(string name) : base(PPS.RenameTypes, name)
  {
    NamespaceTypeSelector = NTS.Origin | NTS.Target;
    CanShowErrorDetails = true;
  }

  public override void ShowErrorFor(TypeInfoViewModel typeInfoViewModel)
  {
    var nspace = TypeManager.GetNamespace(typeInfoViewModel.Model.GetTargetNamespace());
    TNS tns = new TNS(false, true, false);
    var list = nspace.AcceptedTypes.Where(item=> item.GetTargetName() == typeInfoViewModel.Model.GetTargetName())
      .Select(item=>new TypeInfoViewModel(this, item, tns)).ToList();
    var viewModel = new TypeListViewModel(this, new NamespaceViewModel(this, nspace), "Types with duplicated names", tns,list);
    viewModel.IsInvalidMarkVisible = false;
    WindowsManager.ShowWindow<TypeListWindow>(viewModel);
  }
}
