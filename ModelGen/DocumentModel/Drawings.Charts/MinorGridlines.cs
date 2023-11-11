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
    get
    {
      return _Element?.GetObject<DMDC.ChartShapeProperties,DXDC.ChartShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ChartShapeProperties,DXDC.ChartShapeProperties>(value);
    }
  }
  
}
