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
