namespace ModelGenApp.ViewModels;
public class RenamePhaseViewModel : PhaseViewModel
{
  public RenamePhaseViewModel(string name) : base(PPS.Rename, name)
  {
    NamespaceTypeSelector = NTS.Origin | NTS.Target;
    CanShowErrorDetails = true;
  }

  public override void ShowErrorFor(TypeInfoViewModel typeInfoViewModel)
  {
    var nspace = TypeManager.GetNamespace(typeInfoViewModel.Model.GetTargetNamespace());
    var list = nspace.Types
      .Where(item => item.GetTargetName() == typeInfoViewModel.Model.GetTargetName())
      .Select(item => TypeInfoViewModel.Create(this, item, TypeNameSelector)).ToList();
    var viewModel = new TypeListViewModel(this, new NamespaceViewModel(this, nspace), "Types with duplicate names", this.TypeNameSelector, list);
    viewModel.IsInvalidMarkVisible = false;
    WindowsManager.ShowWindow<TypeListWindow>(viewModel);
  }
}
