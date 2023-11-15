namespace DocumentModel.Drawings;


/// <summary>
///   This element allows for an override which changes just the colors, fonts, or effects of a single object, like a table for example.  Currently it is used only to control overrides on the non-top-level masters within a presentation.
/// </summary>
public partial class ThemeOverride: ModelElement<DXD.ThemeOverride>
{
  public ThemeOverride(): base(){ }
  
  public ThemeOverride(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ThemeOverride(DXD.ThemeOverride openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Color Scheme.
  /// </summary>
  [DataMember]
  public DMD.ColorScheme? ColorScheme
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   FontScheme.
  /// </summary>
  [DataMember]
  public DMD.FontScheme? FontScheme
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   FormatScheme.
  /// </summary>
  [DataMember]
  public DMD.FormatScheme? FormatScheme
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
