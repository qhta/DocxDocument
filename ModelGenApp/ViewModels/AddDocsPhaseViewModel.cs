namespace ModelGenApp.ViewModels;

public class AddDocsPhaseViewModel: PhaseResultsViewModel
{
  public AddDocsPhaseViewModel(string name): base (PPS.AddDocs, name, NTS.Origin | NTS.System)
  { 
  }

}
