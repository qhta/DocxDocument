namespace DocumentModel.Drawings;


/// <summary>
///   This element defines an auxiliary color scheme, which includes both a color scheme and color mapping.  This is mainly used for backward compatibility concerns and roundtrips information required by earlier versions.
/// </summary>
public partial class ExtraColorScheme: ModelElement<DXD.ExtraColorScheme>
{
  public ExtraColorScheme(): base(){ }
  
  public ExtraColorScheme(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ExtraColorScheme(DXD.ExtraColorScheme openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ColorScheme.
  /// </summary>
  [DataMember]
  public DMD.ColorScheme? ColorScheme
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ColorMap.
  /// </summary>
  [DataMember]
  public DMD.ColorMap? ColorMap
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ColorMappingType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ColorMappingType");
  }
  
}
