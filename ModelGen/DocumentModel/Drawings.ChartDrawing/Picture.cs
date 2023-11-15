namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Defines the Picture Class.
/// </summary>
public partial class Picture: ModelElement<DXDCD.Picture>
{
  public Picture(): base(){ }
  
  public Picture(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Picture(DXDCD.Picture openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Non-Visual Picture Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualPictureProperties? NonVisualPictureProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Picture Fill.
  /// </summary>
  [DataMember]
  public DMDCD.BlipFill? BlipFill
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDCD.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Style.
  /// </summary>
  [DataMember]
  public DMDCD.Style? Style
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
