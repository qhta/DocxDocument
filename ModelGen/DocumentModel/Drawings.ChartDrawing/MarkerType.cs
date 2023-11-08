namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Defines the MarkerType Class.
/// </summary>
public partial class MarkerType: ModelElement<DXDCD.MarkerType>
{
  public MarkerType(): base(){ }
  
  public MarkerType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MarkerType(DXDCD.MarkerType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Relative X Coordinate.
  /// </summary>
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
  
  
  /// <summary>
  ///   Relative Y Coordinate.
  /// </summary>
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
