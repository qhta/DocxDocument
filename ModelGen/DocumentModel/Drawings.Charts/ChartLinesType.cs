namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ChartLinesType Class.
/// </summary>
public partial class ChartLinesType: ModelElement<DXDC.ChartLinesType>
{
  public ChartLinesType(): base(){ }
  
  public ChartLinesType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartLinesType(DXDC.ChartLinesType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
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
