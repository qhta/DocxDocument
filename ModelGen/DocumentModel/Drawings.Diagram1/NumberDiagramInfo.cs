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
      var element = _Element?.GetFirstChild<DXO19DD11.DiagramAutoBullet>();
      if (element != null)
        return DiagramAutoBulletConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO19DD11.DiagramAutoBullet>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DiagramAutoBulletConverter.CreateOpenXmlElement<DXO19DD11.DiagramAutoBullet>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
