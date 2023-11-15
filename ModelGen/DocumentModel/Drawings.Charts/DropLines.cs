namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Drop Lines.
/// </summary>
public partial class DropLines: ModelElement<DXDC.DropLines>
{
  public DropLines(): base(){ }
  
  public DropLines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DropLines(DXDC.DropLines openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
