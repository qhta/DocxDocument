namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Style Label.
/// </summary>
public partial class ColorTransformStyleLabel: ModelElement<DXDDD.ColorTransformStyleLabel>
{
  public ColorTransformStyleLabel(): base(){ }
  
  public ColorTransformStyleLabel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorTransformStyleLabel(DXDDD.ColorTransformStyleLabel openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get => _Element?.Name;
    set => _ExistingElement.Name = value;
  }
  
  
  /// <summary>
  ///   Fill Color List.
  /// </summary>
  [DataMember]
  public DMDD.FillColorList? FillColorList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType");
  }
  
  
  /// <summary>
  ///   Line Color List.
  /// </summary>
  [DataMember]
  public DMDD.LineColorList? LineColorList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType");
  }
  
  
  /// <summary>
  ///   Effect Color List.
  /// </summary>
  [DataMember]
  public DMDD.EffectColorList? EffectColorList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType");
  }
  
  
  /// <summary>
  ///   Text Line Color List.
  /// </summary>
  [DataMember]
  public DMDD.TextLineColorList? TextLineColorList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType");
  }
  
  
  /// <summary>
  ///   Text Fill Color List.
  /// </summary>
  [DataMember]
  public DMDD.TextFillColorList? TextFillColorList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType");
  }
  
  
  /// <summary>
  ///   Text Effect Color List.
  /// </summary>
  [DataMember]
  public DMDD.TextEffectColorList? TextEffectColorList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType");
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMDD.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
