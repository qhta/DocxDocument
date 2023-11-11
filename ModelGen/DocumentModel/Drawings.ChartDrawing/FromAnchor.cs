namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Starting Anchor Point.
/// </summary>
public partial class FromAnchor: ModelElement<DXDCD.FromAnchor>
{
  public FromAnchor(): base(){ }
  
  public FromAnchor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FromAnchor(DXDCD.FromAnchor openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDCD.XPosition? XPosition
  {
    get
    {
      return _Element?.GetObject<DMDCD.XPosition,DXDCD.XPosition>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.XPosition,DXDCD.XPosition>(value);
    }
  }
  
  [DataMember]
  public DMDCD.YPosition? YPosition
  {
    get
    {
      return _Element?.GetObject<DMDCD.YPosition,DXDCD.YPosition>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.YPosition,DXDCD.YPosition>(value);
    }
  }
  
}
