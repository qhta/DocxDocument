namespace DocumentModel.Drawings;


/// <summary>
///   Underline Fill.
/// </summary>
public partial class UnderlineFill: ModelElement<DXD.UnderlineFill>
{
  public UnderlineFill(): base(){ }
  
  public UnderlineFill(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UnderlineFill(DXD.UnderlineFill openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   NoFill.
  /// </summary>
  [DataMember]
  public DMD.NoFill? NoFill
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   SolidFill.
  /// </summary>
  [DataMember]
  public DMD.SolidFill? SolidFill
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   GradientFill.
  /// </summary>
  [DataMember]
  public DMD.GradientFill? GradientFill
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   BlipFill.
  /// </summary>
  [DataMember]
  public DMD.BlipFill? BlipFill
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Pattern Fill.
  /// </summary>
  [DataMember]
  public DMD.PatternFill? PatternFill
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Group Fill.
  /// </summary>
  [DataMember]
  public DMD.GroupFill? GroupFill
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
