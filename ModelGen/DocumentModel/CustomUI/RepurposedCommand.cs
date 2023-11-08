namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the RepurposedCommand Class.
/// </summary>
public partial class RepurposedCommand: ModelElement<DXOCUI.RepurposedCommand>
{
  public RepurposedCommand(): base(){ }
  
  public RepurposedCommand(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RepurposedCommand(DXOCUI.RepurposedCommand openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   onAction
  /// </summary>
  [DataMember]
  public String? OnAction
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.OnAction);
    }
    set
    {
      _ExistingElement.OnAction = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   enabled
  /// </summary>
  [DataMember]
  public Boolean? Enabled
  {
    get
    {
      return _Element?.Enabled?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Enabled = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Enabled = null;
    }
  }
  
  
  /// <summary>
  ///   getEnabled
  /// </summary>
  [DataMember]
  public String? GetEnabled
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetEnabled);
    }
    set
    {
      _ExistingElement.GetEnabled = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   idMso
  /// </summary>
  [DataMember]
  public String? IdMso
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.IdMso);
    }
    set
    {
      _ExistingElement.IdMso = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
