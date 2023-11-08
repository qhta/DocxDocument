namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the StyleReference Class.
/// </summary>
public partial class StyleReference: ModelElement<DXO13DCS.StyleReference>
{
  public StyleReference(): base(){ }
  
  public StyleReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleReference(DXO13DCS.StyleReference openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   idx, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public UInt32? Index
  {
    get
    {
      return _Element?.Index?.Value;
    }
    set
    {
      _ExistingElement.Index = value;
    }
  }
  
  
  /// <summary>
  ///   mods, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public DM.ListOf<String>? Modifiers
  {
    get
    {
      return ListValueConverter.GetValue(_Element?.Modifiers);
    }
    set
    {
      if (value != null)
        _ExistingElement.Modifiers = ListValueConverter.CreateListValue<DX.StringValue>(value);
      else
        _ExistingElement.Modifiers = null;
    }
  }
  
}
