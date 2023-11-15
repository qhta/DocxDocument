namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the SeriesLines Class.
/// </summary>
public partial class SeriesLines: ModelElement<DXDC.SeriesLines>
{
  public SeriesLines(): base(){ }
  
  public SeriesLines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SeriesLines(DXDC.SeriesLines openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
