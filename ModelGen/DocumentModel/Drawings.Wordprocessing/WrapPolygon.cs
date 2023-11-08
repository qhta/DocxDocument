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
        _ExistingElement.Edited = new BooleanValue { Value = (Boolean)value };
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
      var element = _Element?.GetFirstChild<DXDW.StartPoint>();
      if (element != null)
        return StartPointConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.StartPoint>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StartPointConverter.CreateOpenXmlElement<DXDW.StartPoint>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
