namespace ModelGenApp.ViewModels;

public class AddDocsPhaseViewModel: PhaseViewModel
{
  public AddDocsPhaseViewModel(string name): base (PPS.AddDocs, name)
  { 
    NamespaceTypeSelector = NTS.Origin | NTS.System;
  }

}
