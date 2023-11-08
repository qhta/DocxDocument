namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the ContextualTabSet Class.
/// </summary>
public partial class ContextualTabSet: ModelElement<DXOCUI.ContextualTabSet>
{
  public ContextualTabSet(): base(){ }
  
  public ContextualTabSet(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ContextualTabSet(DXOCUI.ContextualTabSet openXmlElement): base(openXmlElement) { }
  
  
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
  
  
  /// <summary>
  ///   visible
  /// </summary>
  [DataMember]
  public Boolean? Visible
  {
    get
    {
      return _Element?.Visible?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Visible = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Visible = null;
    }
  }
  
  
  /// <summary>
  ///   getVisible
  /// </summary>
  [DataMember]
  public String? GetVisible
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetVisible);
    }
    set
    {
      _ExistingElement.GetVisible = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
