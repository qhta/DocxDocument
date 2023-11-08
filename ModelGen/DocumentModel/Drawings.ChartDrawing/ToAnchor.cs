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
      var element = _Element?.GetFirstChild<DXDCD.XPosition>();
      if (element != null)
        return XPositionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.XPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = XPositionConverter.CreateOpenXmlElement<DXDCD.XPosition>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD.YPosition? YPosition
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.YPosition>();
      if (element != null)
        return YPositionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.YPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = YPositionConverter.CreateOpenXmlElement<DXDCD.YPosition>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
