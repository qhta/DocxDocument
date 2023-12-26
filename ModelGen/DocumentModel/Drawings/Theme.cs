namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the root level complex type associated with a shared style sheet (or theme).  This element holds all the different formatting options available to a document through a theme and defines the overall look and feel of the document when themed objects are used within the document.
/// </summary>
public partial class Theme: ModelElement<DXD.Theme>
{
  public Theme(): base(){ }
  
  public Theme(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Theme(DXD.Theme openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the name given to the theme.
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
  public String? ThemeId
  {
    get => _Element?.ThemeId;
    set => _ExistingElement.ThemeId = value;
  }
  
  
  /// <summary>
  ///   ThemeElements.
  /// </summary>
  [DataMember]
  public DMD.ThemeElements? ThemeElements
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ObjectDefaults.
  /// </summary>
  [DataMember]
  public DMD.ObjectDefaults? ObjectDefaults
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ExtraColorSchemeList.
  /// </summary>
  [DataMember]
  public DMD.ExtraColorSchemeList? ExtraColorSchemeList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   CustomColorList.
  /// </summary>
  [DataMember]
  public DMD.CustomColorList? CustomColorList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   OfficeStyleSheetExtensionList.
  /// </summary>
  [DataMember]
  public DMD.OfficeStyleSheetExtensionList? OfficeStyleSheetExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
