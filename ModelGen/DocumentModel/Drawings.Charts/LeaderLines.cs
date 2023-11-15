namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Leader Lines.
/// </summary>
public partial class LeaderLines: ModelElement<DXDC.LeaderLines>
{
  public LeaderLines(): base(){ }
  
  public LeaderLines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LeaderLines(DXDC.LeaderLines openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
