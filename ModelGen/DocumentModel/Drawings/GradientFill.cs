namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a gradient fill.
/// </summary>
public partial class GradientFill: ModelElement<DXD.GradientFill>
{
  public GradientFill(): base(){ }
  
  public GradientFill(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GradientFill(DXD.GradientFill openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  [DataMember]
  public Boolean? RotateWithShape
  {
    get => _Element?.RotateWithShape?.Value;
    set => _ExistingElement.RotateWithShape = value;
  }
  
  
  /// <summary>
  ///   Gradient Stop List.
  /// </summary>
  [DataMember]
  public DMD.GradientStopList? GradientStopList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMD.LinearGradientFill? LinearGradientFill
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public DMD.PathGradientFill? PathGradientFill
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMD.TileRectangle? TileRectangle
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.RelativeRectangleType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.RelativeRectangleType");
  }
  
}
