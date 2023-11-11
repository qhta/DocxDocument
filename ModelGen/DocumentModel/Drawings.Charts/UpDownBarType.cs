namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the UpDownBarType Class.
/// </summary>
public partial class UpDownBarType: ModelElement<DXDC.UpDownBarType>
{
  public UpDownBarType(): base(){ }
  
  public UpDownBarType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UpDownBarType(DXDC.UpDownBarType openXmlElement): base(openXmlElement) { }
  
  
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
