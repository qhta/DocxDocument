namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Shape Drawing Properties.
/// </summary>
public partial class NonVisualShapeDrawingProperties: ModelElement<DXDCD.NonVisualShapeDrawingProperties>
{
  public NonVisualShapeDrawingProperties(): base(){ }
  
  public NonVisualShapeDrawingProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualShapeDrawingProperties(DXDCD.NonVisualShapeDrawingProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Text Box
  /// </summary>
  [DataMember]
  public Boolean? TextBox
  {
    get => _Element?.TextBox?.Value;
    set => _ExistingElement.TextBox = value;
  }
  
  
  /// <summary>
  ///   Shape Locks.
  /// </summary>
  [DataMember]
  public DMD.ShapeLocks? ShapeLocks
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
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
