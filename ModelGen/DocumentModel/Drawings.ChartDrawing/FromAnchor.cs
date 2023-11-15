namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Starting Anchor Point.
/// </summary>
public partial class FromAnchor: ModelElement<DXDCD.FromAnchor>
{
  public FromAnchor(): base(){ }
  
  public FromAnchor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FromAnchor(DXDCD.FromAnchor openXmlElement): base(openXmlElement) { }
  
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
