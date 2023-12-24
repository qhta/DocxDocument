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
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
  
  /// <summary>
  ///   vid, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Vid
  {
    get => _Element?.Vid;
    set => _ExistingElement.Vid = value;
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
