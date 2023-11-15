namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Group Shape Drawing Properties.
/// </summary>
public partial class NonVisualGroupShapeDrawingProperties: ModelElement<DXDCD.NonVisualGroupShapeDrawingProperties>
{
  public NonVisualGroupShapeDrawingProperties(): base(){ }
  
  public NonVisualGroupShapeDrawingProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualGroupShapeDrawingProperties(DXDCD.NonVisualGroupShapeDrawingProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GroupShapeLocks.
  /// </summary>
  [DataMember]
  public DMD.GroupShapeLocks? GroupShapeLocks
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  [DataMember]
  public DMD.NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
