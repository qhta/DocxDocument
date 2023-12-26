namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the style information for a shape.
/// </summary>
public partial class ShapeStyle: ModelElement<DXD.ShapeStyle>
{
  public ShapeStyle(): base(){ }
  
  public ShapeStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeStyle(DXD.ShapeStyle openXmlElement): base(openXmlElement) { }
  
  
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
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
