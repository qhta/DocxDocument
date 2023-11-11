namespace DocumentModel.Drawings.Diagram1;


/// <summary>
///   Defines the NumberDiagramInfo Class.
/// </summary>
public partial class NumberDiagramInfo: ModelElement<DXO19DD11.NumberDiagramInfo>
{
  public NumberDiagramInfo(): base(){ }
  
  public NumberDiagramInfo(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberDiagramInfo(DXO19DD11.NumberDiagramInfo openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   lvl, this property is only available in Office 2019 and later.
  /// </summary>
  [DataMember]
  public UInt32? Lvl
  {
    get
    {
      return _Element?.Lvl?.Value;
    }
    set
    {
      _ExistingElement.Lvl = value;
    }
  }
  
  
  /// <summary>
  ///   DiagramAutoBullet.
  /// </summary>
  [DataMember]
  public DMDD1.DiagramAutoBullet? DiagramAutoBullet
  {
    get
    {
      return _Element?.GetObject<DMDD1.DiagramAutoBullet,DXO19DD11.DiagramAutoBullet>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD1.DiagramAutoBullet,DXO19DD11.DiagramAutoBullet>(value);
    }
  }
  
}
