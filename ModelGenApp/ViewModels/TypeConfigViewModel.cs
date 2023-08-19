namespace ModelGenApp.ViewModels;
public class TypeConfigViewModel : VisibleViewModel
{

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Original_namespace),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Original_namespace_tooltip)
    )]
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


  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Excluded_namespace),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Excluded_namespace_tooltip)
    )]
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

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Original_name),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Original_name_tooltip)
    )]  
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

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Included_type),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Included_type_tooltip)
    )]
  public bool IncludedType
  {
    get { return _Included; }
    set
    {
      if (_Included != value)
      {
        _Included = value;
        NotifyPropertyChanged(nameof(IncludedType));
        if (value)
          ExcludedType = false;
      }
    }
  }
  private bool _Included;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Excluded_type),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Excluded_type_tooltip)
    )]
  public bool ExcludedType
  {
    get { return _Excluded; }
    set
    {
      if (_Excluded != value)
      {
        _Excluded = value;
        NotifyPropertyChanged(nameof(ExcludedType));
      }
    }
  }
  private bool _Excluded;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Target_namespace),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Target_namespace_tooltip)
    )]
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

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Target_name),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings."+nameof(CommonStrings.Target_name_tooltip)
    )]
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

}
