namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Ending Anchor Point.
/// </summary>
public partial class ToAnchor: ModelElement<DXDCD.ToAnchor>
{
  public ToAnchor(): base(){ }
  
  public ToAnchor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ToAnchor(DXDCD.ToAnchor openXmlElement): base(openXmlElement) { }
  
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
