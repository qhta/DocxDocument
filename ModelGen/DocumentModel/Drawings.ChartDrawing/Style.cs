namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Shape Style.
/// </summary>
public partial class Style: ModelElement<DXDCD.Style>
{
  public Style(): base(){ }
  
  public Style(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Style(DXDCD.Style openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   LineReference.
  /// </summary>
  [DataMember]
  public DMD.LineReference? LineReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.StyleMatrixReferenceType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.StyleMatrixReferenceType");
  }
  
  
  /// <summary>
  ///   FillReference.
  /// </summary>
  [DataMember]
  public DMD.FillReference? FillReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.StyleMatrixReferenceType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.StyleMatrixReferenceType");
  }
  
  
  /// <summary>
  ///   EffectReference.
  /// </summary>
  [DataMember]
  public DMD.EffectReference? EffectReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.StyleMatrixReferenceType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.StyleMatrixReferenceType");
  }
  
  
  /// <summary>
  ///   Font Reference.
  /// </summary>
  [DataMember]
  public DMD.FontReference? FontReference
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
