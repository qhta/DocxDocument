namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Up Bars.
/// </summary>
public partial class UpBars: ModelElement<DXDC.UpBars>
{
  public UpBars(): base(){ }
  
  public UpBars(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UpBars(DXDC.UpBars openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
