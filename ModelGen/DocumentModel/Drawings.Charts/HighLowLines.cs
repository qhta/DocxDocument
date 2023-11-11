namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the HighLowLines Class.
/// </summary>
public partial class HighLowLines: ModelElement<DXDC.HighLowLines>
{
  public HighLowLines(): base(){ }
  
  public HighLowLines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HighLowLines(DXDC.HighLowLines openXmlElement): base(openXmlElement) { }
  
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
