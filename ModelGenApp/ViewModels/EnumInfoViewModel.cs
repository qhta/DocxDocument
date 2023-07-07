namespace ModelGenApp.ViewModels;
public class EnumInfoViewModel : ViewModel<EnumInfo>
{
  public EnumInfoViewModel(EnumInfo EnumInfo, bool isOriginal) : base(EnumInfo)
  {
    IsOriginal = isOriginal;
  }

  private bool IsOriginal;

  public string Name
  {
    get
    {
      if (IsOriginal)
        return Model.Name;
      return Model.NewName ?? Model.Name;
    }
  }

}

