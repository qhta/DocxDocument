namespace DocumentModel.Drawings.ChartDrawings10;


/// <summary>
///   Defines the NonVisualContentPartProperties Class.
/// </summary>
public partial class NonVisualContentPartProperties: ModelElement<DXO10DCD.NonVisualContentPartProperties>
{
  public NonVisualContentPartProperties(): base(){ }
  
  public NonVisualContentPartProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualContentPartProperties(DXO10DCD.NonVisualContentPartProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  [DataMember]
  public DMDCD10.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   NonVisualInkContentPartProperties.
  /// </summary>
  [DataMember]
  public DMDCD10.NonVisualInkContentPartProperties? NonVisualInkContentPartProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
