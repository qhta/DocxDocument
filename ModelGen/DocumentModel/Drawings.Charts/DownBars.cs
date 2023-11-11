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
