namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Shape Extent.
/// </summary>
public partial class Extent: ModelElement<DXDCD.Extent>
{
  public Extent(): base(){ }
  
  public Extent(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Extent(DXDCD.Extent openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Extent Length
  /// </summary>
  [DataMember]
  public Int64? Cx
  {
    get
    {
      return _Element?.Cx?.Value;
    }
    set
    {
      _ExistingElement.Cx = value;
    }
  }
  
  
  /// <summary>
  ///   Extent Width
  /// </summary>
  [DataMember]
  public Int64? Cy
  {
    get
    {
      return _Element?.Cy?.Value;
    }
    set
    {
      _ExistingElement.Cy = value;
    }
  }
  
}
