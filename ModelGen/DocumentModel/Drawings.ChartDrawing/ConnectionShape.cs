namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Connection Shape.
/// </summary>
public partial class ConnectionShape: ModelElement<DXDCD.ConnectionShape>
{
  public ConnectionShape(): base(){ }
  
  public ConnectionShape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ConnectionShape(DXDCD.ConnectionShape openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  [DataMember]
  public String? Macro
  {
    get => _Element?.Macro;
    set => _ExistingElement.Macro = value;
  }
  
  
  /// <summary>
  ///   Publish to Server
  /// </summary>
  [DataMember]
  public Boolean? Published
  {
    get => _Element?.Published?.Value;
    set => _ExistingElement.Published = value;
  }
  
  
  /// <summary>
  ///   Connector Non Visual Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Shape Properties.
  /// </summary>
  [DataMember]
  public DMDCD.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Connection Shape Style.
  /// </summary>
  [DataMember]
  public DMDCD.Style? Style
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
