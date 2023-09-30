namespace ModelGenApp.ViewModels;
public class ConvertPhaseViewModel : PhaseResultsViewModel
{
  public ConvertPhaseViewModel(string name) : base(PPS.ConvertTypes, name)
  {
    NamespaceTypeSelector = NTS.Origin | NTS.Target;
    CanShowErrorDetails = true;
    ShowTargetsOnlyEnabled = true;
    ShowTargetsOnly = true;
  }

}
