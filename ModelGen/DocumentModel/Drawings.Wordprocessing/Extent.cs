namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Inline Drawing Object Extents.
/// </summary>
public partial class Extent: ModelElement<DXDW.Extent>
{
  public Extent(): base(){ }
  
  public Extent(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Extent(DXDW.Extent openXmlElement): base(openXmlElement) { }
  
  
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
