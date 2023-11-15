namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Group Shape Properties.
/// </summary>
public partial class NonVisualGroupShapeProperties: ModelElement<DXDCD.NonVisualGroupShapeProperties>
{
  public NonVisualGroupShapeProperties(): base(){ }
  
  public NonVisualGroupShapeProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualGroupShapeProperties(DXDCD.NonVisualGroupShapeProperties openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Non-Visual Group Shape Drawing Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
