namespace DocumentModel.Theme;


/// <summary>
///   Defines the ThemeFamily Class.
/// </summary>
public partial class ThemeFamily: ModelElement<DXO13T.ThemeFamily>
{
  public ThemeFamily(): base(){ }
  
  public ThemeFamily(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ThemeFamily(DXO13T.ThemeFamily openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   name, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Name
  {
    get => _Element?.Name;
    set => _ExistingElement.Name = value;
  }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   vid, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Vid
  {
    get => HexIntConverter.GetValue(_Element?.Vid);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMT.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
