namespace ModelGenApp.ViewModels;
public class CodeGenPhaseViewModel : PhaseResultsViewModel
{
  public CodeGenPhaseViewModel(string name) : base(PPS.CodeGen, name)
  {
    NamespaceTypeSelector = NTS.Target;
    CanShowErrorDetails = true;
  }

}
