namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Tight Wrapping Extents Polygon.
/// </summary>
public partial class WrapPolygon: ModelElement<DXDW.WrapPolygon>
{
  public WrapPolygon(): base(){ }
  
  public WrapPolygon(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WrapPolygon(DXDW.WrapPolygon openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Wrapping Points Modified
  /// </summary>
  [DataMember]
  public Boolean? Edited
  {
    get
    {
      return _Element?.Edited?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Edited = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Edited = null;
    }
  }
  
  
  /// <summary>
  ///   Wrapping Polygon Start.
  /// </summary>
  [DataMember]
  public DMDW.StartPoint? StartPoint
  {
    get
    {
      return _Element?.GetObject<DMDW.StartPoint,DXDW.StartPoint>();
    }
    set
    {
      _ExistingElement.SetObject<DMDW.StartPoint,DXDW.StartPoint>(value);
    }
  }
  
}
