namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Minor Gridlines.
/// </summary>
public partial class MinorGridlines: ModelElement<DXDC.MinorGridlines>
{
  public MinorGridlines(): base(){ }
  
  public MinorGridlines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MinorGridlines(DXDC.MinorGridlines openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
