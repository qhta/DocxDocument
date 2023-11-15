namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Connection Shape Drawing Properties.
/// </summary>
public partial class NonVisualConnectionShapeProperties: ModelElement<DXDCD.NonVisualConnectionShapeProperties>
{
  public NonVisualConnectionShapeProperties(): base(){ }
  
  public NonVisualConnectionShapeProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualConnectionShapeProperties(DXDCD.NonVisualConnectionShapeProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Connection Shape Locks.
  /// </summary>
  [DataMember]
  public DMD.ConnectionShapeLocks? ConnectionShapeLocks
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Connection Start.
  /// </summary>
  [DataMember]
  public DMD.StartConnection? StartConnection
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ConnectionType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ConnectionType");
  }
  
  
  /// <summary>
  ///   Connection End.
  /// </summary>
  [DataMember]
  public DMD.EndConnection? EndConnection
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ConnectionType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.ConnectionType");
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
