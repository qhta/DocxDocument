namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Shape Properties.
/// </summary>
public partial class NonVisualShapeProperties: ModelElement<DXDCD.NonVisualShapeProperties>
{
  public NonVisualShapeProperties(): base(){ }
  
  public NonVisualShapeProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualShapeProperties(DXDCD.NonVisualShapeProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Chart Non Visual Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Non-Visual Shape Drawing Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
