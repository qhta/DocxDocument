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
