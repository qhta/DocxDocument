namespace ModelGenApp.ViewModels;

public class AddDocsPhaseViewModel: PhaseResultsViewModel
{
  public AddDocsPhaseViewModel(string name): base (PPS.AddDocs, name)
  { 
    NamespaceTypeSelector = NTS.Origin | NTS.System;
  }

}
