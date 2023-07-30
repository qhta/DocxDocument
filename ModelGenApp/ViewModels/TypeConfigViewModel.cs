namespace ModelGenApp.ViewModels;
public class TypeConfigViewModel : ViewModel, IEditableObject
{

  public string OrigNamespace
  {
    get { return _OrigNamespace; }
    set
    {
      if (_OrigNamespace != value)
      {
        _OrigNamespace = value;
        NotifyPropertyChanged(nameof(OrigNamespace));
      }
    }
  }
  private string _OrigNamespace = string.Empty;

  public string OrigName
  {
    get { return _OrigName; }
    set
    {
      if (_OrigName != value)
      {
        _OrigName = value;
        NotifyPropertyChanged(nameof(OrigName));
      }
    }
  }
  private string _OrigName = string.Empty;

  public bool ExcludedNamespace
  {
    get { return _ExcludedNamespace; }
    set
    {
      if (_ExcludedNamespace != value)
      {
        _ExcludedNamespace = value;
        NotifyPropertyChanged(nameof(ExcludedNamespace));
      }
    }
  }
  private bool _ExcludedNamespace;

  public bool Included
  {
    get { return _Included; }
    set
    {
      if (_Included != value)
      {
        _Included = value;
        NotifyPropertyChanged(nameof(Included));
        if (value)
          Excluded = false;
      }
    }
  }
  private bool _Included;

  public bool Excluded
  {
    get { return _Excluded; }
    set
    {
      if (_Excluded != value)
      {
        _Excluded = value;
        NotifyPropertyChanged(nameof(Excluded));
      }
    }
  }
  private bool _Excluded;

  public string? TargetNamespace
  {
    get { return _TargetNamespace; }
    set
    {
      if (_TargetNamespace != value)
      {
        _TargetNamespace = value;
        NotifyPropertyChanged(nameof(TargetNamespace));
      }
    }
  }
  private string? _TargetNamespace;

  public string? TargetName
  {
    get { return _TargetName; }
    set
    {
      if (_TargetName != value)
      {
        _TargetName = value;
        NotifyPropertyChanged(nameof(TargetName));
      }
    }
  }
  private string? _TargetName;

  public new bool IsValid
  {
    get { return _IsValid; }
    set
    {
      if (_IsValid != value)
      {
        _IsValid = value;
        NotifyPropertyChanged(nameof(IsValid));
      }
    }
  }
  private bool _IsValid = true;

  public string? ValidationMsg
  {
    get { return _ValidationMsg; }
    set
    {
      if (_ValidationMsg != value)
      {
        _ValidationMsg = value;
        NotifyPropertyChanged(nameof(ValidationMsg));
      }
    }
  }
  private string? _ValidationMsg;

  public void BeginEdit()
  {
    //throw new NotImplementedException();
  }

  public void CancelEdit()
  {
    //throw new NotImplementedException();
  }

  public void EndEdit()
  {
    //throw new NotImplementedException();
  }
}
