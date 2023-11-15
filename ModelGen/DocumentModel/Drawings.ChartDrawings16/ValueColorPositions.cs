namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the ValueColorPositions Class.
/// </summary>
public partial class ValueColorPositions: ModelElement<DXO16DCD.ValueColorPositions>
{
  public ValueColorPositions(): base(){ }
  
  public ValueColorPositions(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ValueColorPositions(DXO16DCD.ValueColorPositions openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   count, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Int32? Count
  {
    get => _Element?.Count?.Value;
    set => _ExistingElement.Count = value;
  }
  
  
  /// <summary>
  ///   MinValueColorEndPosition.
  /// </summary>
  [DataMember]
  public DMDCD16.MinValueColorEndPosition? MinValueColorEndPosition
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlValueColorEndPositionElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlValueColorEndPositionElement");
  }
  
  
  /// <summary>
  ///   ValueColorMiddlePosition.
  /// </summary>
  [DataMember]
  public DMDCD16.ValueColorMiddlePosition? ValueColorMiddlePosition
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   MaxValueColorEndPosition.
  /// </summary>
  [DataMember]
  public DMDCD16.MaxValueColorEndPosition? MaxValueColorEndPosition
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlValueColorEndPositionElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlValueColorEndPositionElement");
  }
  
}
