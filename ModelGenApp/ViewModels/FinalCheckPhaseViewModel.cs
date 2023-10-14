namespace ModelGenApp.ViewModels;

public class FinalCheckPhaseViewModel : PhaseResultsViewModel
{
  public FinalCheckPhaseViewModel(string name) : base(PPS.ConvertTypes, name, NTS.Target)
  {
    CanShowErrorDetails = true;
    ShowTargetsOnlyEnabled = false;
    ShowTargetsOnly = true;
  }

}
