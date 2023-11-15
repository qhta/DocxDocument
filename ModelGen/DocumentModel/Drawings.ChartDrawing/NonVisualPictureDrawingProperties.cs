namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Picture Drawing Properties.
/// </summary>
public partial class NonVisualPictureDrawingProperties: ModelElement<DXDCD.NonVisualPictureDrawingProperties>
{
  public NonVisualPictureDrawingProperties(): base(){ }
  
  public NonVisualPictureDrawingProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualPictureDrawingProperties(DXDCD.NonVisualPictureDrawingProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   preferRelativeResize
  /// </summary>
  [DataMember]
  public Boolean? PreferRelativeResize
  {
    get => _Element?.PreferRelativeResize?.Value;
    set => _ExistingElement.PreferRelativeResize = value;
  }
  
  
  /// <summary>
  ///   PictureLocks.
  /// </summary>
  [DataMember]
  public DMD.PictureLocks? PictureLocks
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   NonVisualPicturePropertiesExtensionList.
  /// </summary>
  [DataMember]
  public DMD.NonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
