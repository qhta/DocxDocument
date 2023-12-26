namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the theme formatting options for the theme and is the workhorse of the theme.  This is where the bulk of the shared theme information is contained and used by a document.  This element contains the color scheme, font scheme, and format scheme elements which define the different formatting aspects of what a theme defines.
/// </summary>
public partial class ThemeElements: ModelElement<DXD.ThemeElements>
{
  public ThemeElements(): base(){ }
  
  public ThemeElements(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ThemeElements(DXD.ThemeElements openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ColorScheme.
  /// </summary>
  [DataMember]
  public DMD.ColorScheme? ColorScheme
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Font Scheme.
  /// </summary>
  [DataMember]
  public DMD.FontScheme? FontScheme
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Format Scheme.
  /// </summary>
  [DataMember]
  public DMD.FormatScheme? FormatScheme
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
