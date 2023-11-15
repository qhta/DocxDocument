namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the ShapeNonVisualProperties Class.
/// </summary>
public partial class ShapeNonVisualProperties: ModelElement<DXOD.ShapeNonVisualProperties>
{
  public ShapeNonVisualProperties(): base(){ }
  
  public ShapeNonVisualProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeNonVisualProperties(DXOD.ShapeNonVisualProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  [DataMember]
  public DMDO.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   NonVisualDrawingShapeProperties.
  /// </summary>
  [DataMember]
  public DMDO.NonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
