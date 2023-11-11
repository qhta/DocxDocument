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
