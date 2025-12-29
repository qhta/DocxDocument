namespace DocxEd.ViewModels;

public class FinalFixPhaseViewModel : PhaseResultsViewModel
{
  public FinalFixPhaseViewModel(string name) : base(PPS.FinalFix, name, NTS.Target)
  {
    CanShowErrorDetails = true;
    ShowTargetsOnlyEnabled = false;
    ShowTargetsOnly = true;
  }

}
