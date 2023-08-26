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
    //var list = nspace.Types
    //  .Where(item => item.GetTargetName() == typeInfoViewModel.Model.GetTargetName())
    //  .Select(item => TypeInfoViewModel.Create(this, item, TypeNameSelector)).ToList();
    var name = typeInfoViewModel.Model.GetFullName(true, false, false);
    //var filter = new TypeInfoFilter(new Predicate<TypeInfo>(info => info.GetFullName(true, false, false) == name));
    var filter = new TypeInfoFilter(SummaryInfoKind.TypesWithSameName, name);
    var viewModel = new TypeListViewModel(this, 
      new NamespaceViewModel(this, nspace), SummaryInfoKind.TypesWithSameName.ToString(), this.TypeNameSelector, TKS.Any, filter);
    viewModel.IsInvalidMarkVisible = false;
    viewModel.FillItems();
    WindowsManager.ShowWindow<TypeListWindow>(viewModel);
  }
}
