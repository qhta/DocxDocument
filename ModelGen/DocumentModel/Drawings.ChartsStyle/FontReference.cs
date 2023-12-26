namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the FontReference Class.
/// </summary>
public partial class FontReference: ModelElement<DXO13DCS.FontReference>
{
  public FontReference(): base(){ }
  
  public FontReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FontReference(DXO13DCS.FontReference openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   mods, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public DM.ListOf<String>? Modifiers
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
  }
  
}
