namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Defines the MarkerType Class.
/// </summary>
public partial class MarkerType: ModelElement<DXDCD.MarkerType>
{
  public MarkerType(): base(){ }
  
  public MarkerType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MarkerType(DXDCD.MarkerType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Relative X Coordinate.
  /// </summary>
  [DataMember]
  public DMDCD.XPosition? XPosition
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   Relative Y Coordinate.
  /// </summary>
  [DataMember]
  public DMDCD.YPosition? YPosition
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
}
