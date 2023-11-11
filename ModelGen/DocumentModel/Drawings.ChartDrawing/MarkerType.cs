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
      return _Element?.GetObject<DMDCD.XPosition,DXDCD.XPosition>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.XPosition,DXDCD.XPosition>(value);
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
      return _Element?.GetObject<DMDCD.YPosition,DXDCD.YPosition>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.YPosition,DXDCD.YPosition>(value);
    }
  }
  
}
