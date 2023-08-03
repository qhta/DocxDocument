namespace ModelGenApp.ViewModels;
public class EnumInfoViewModel : ViewModel<EnumInfo>
{
  public EnumInfoViewModel(PhaseViewModel phase, EnumInfo enumInfo, NKS typeNameSelector) : base(enumInfo)
  {
    NameTypeSelector = typeNameSelector;
  }

  private NKS NameTypeSelector;

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
}

