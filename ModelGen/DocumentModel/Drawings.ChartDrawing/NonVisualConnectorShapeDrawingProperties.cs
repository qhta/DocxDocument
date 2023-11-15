namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Connector Non Visual Properties.
/// </summary>
public partial class NonVisualConnectorShapeDrawingProperties: ModelElement<DXDCD.NonVisualConnectorShapeDrawingProperties>
{
  public NonVisualConnectorShapeDrawingProperties(): base(){ }
  
  public NonVisualConnectorShapeDrawingProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualConnectorShapeDrawingProperties(DXDCD.NonVisualConnectorShapeDrawingProperties openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Non-Visual Connection Shape Drawing Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
