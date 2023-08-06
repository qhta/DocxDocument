namespace ModelGenApp.ViewModels;
public class EnumInfoViewModel : ViewModel<EnumInfo>, IAcceptable
{
  public EnumInfoViewModel(PhaseViewModel phase, EnumInfo enumInfo, NKS typeNameSelector) : base(enumInfo)
  {
    Phase = phase;
    NameTypeSelector = typeNameSelector;
  }

  public PhaseViewModel Phase {get; private set; }

  public NKS NameTypeSelector {get; private set; }

  [DataGridColumn]
  public string Name
  {
    get
    {
      if (NameTypeSelector.Target)
        return Model.NewName ?? Model.Name;
      return Model.Name;

    }
  }

  [DataGridColumn]
  public int? Value => Model.Value;

  public bool IsAccepted => Model.IsAcceptedAfter(Phase.PhaseNum);
}

