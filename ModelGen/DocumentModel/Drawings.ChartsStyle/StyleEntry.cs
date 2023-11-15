namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the StyleEntry Class.
/// </summary>
public partial class StyleEntry: ModelElement<DXO13DCS.StyleEntry>
{
  public StyleEntry(): base(){ }
  
  public StyleEntry(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleEntry(DXO13DCS.StyleEntry openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   mods, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public DM.ListOf<String>? Modifiers
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
  }
  
  
  /// <summary>
  ///   LineReference.
  /// </summary>
  [DataMember]
  public DMDCS.LineReference? LineReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference");
  }
  
  
  /// <summary>
  ///   LineWidthScale.
  /// </summary>
  [DataMember]
  public DMDCS.LineWidthScale? LineWidthScale
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   FillReference.
  /// </summary>
  [DataMember]
  public DMDCS.FillReference? FillReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference");
  }
  
  
  /// <summary>
  ///   EffectReference.
  /// </summary>
  [DataMember]
  public DMDCS.EffectReference? EffectReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference");
  }
  
  
  /// <summary>
  ///   FontReference.
  /// </summary>
  [DataMember]
  public DMDCS.FontReference? FontReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDCS.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   TextCharacterPropertiesType.
  /// </summary>
  [DataMember]
  public DMDCS.TextCharacterPropertiesType? TextCharacterPropertiesType
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   TextBodyProperties.
  /// </summary>
  [DataMember]
  public DMDCS.TextBodyProperties? TextBodyProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMDCS.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
