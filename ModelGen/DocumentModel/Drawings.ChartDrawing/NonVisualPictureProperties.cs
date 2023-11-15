namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Picture Properties.
/// </summary>
public partial class NonVisualPictureProperties: ModelElement<DXDCD.NonVisualPictureProperties>
{
  public NonVisualPictureProperties(): base(){ }
  
  public NonVisualPictureProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualPictureProperties(DXDCD.NonVisualPictureProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Non-Visual Picture Drawing Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
