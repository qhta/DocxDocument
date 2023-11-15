namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Down Bars.
/// </summary>
public partial class DownBars: ModelElement<DXDC.DownBars>
{
  public DownBars(): base(){ }
  
  public DownBars(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DownBars(DXDC.DownBars openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
