namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Ending Anchor Point.
/// </summary>
public partial class ToAnchor: ModelElement<DXDCD.ToAnchor>
{
  public ToAnchor(): base(){ }
  
  public ToAnchor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ToAnchor(DXDCD.ToAnchor openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDCD.XPosition? XPosition
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  [DataMember]
  public DMDCD.YPosition? YPosition
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
}
