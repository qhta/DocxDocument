namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Drop Lines.
/// </summary>
public partial class DropLines: ModelElement<DXDC.DropLines>
{
  public DropLines(): base(){ }
  
  public DropLines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DropLines(DXDC.DropLines openXmlElement): base(openXmlElement) { }
  
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
