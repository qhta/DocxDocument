namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Major Gridlines.
/// </summary>
public partial class MajorGridlines: ModelElement<DXDC.MajorGridlines>
{
  public MajorGridlines(): base(){ }
  
  public MajorGridlines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MajorGridlines(DXDC.MajorGridlines openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
