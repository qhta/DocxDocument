namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Through Wrapping.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IWrapPolygon))]
public class WrapThrough: IWrapThrough
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public WrapTextValues? WrapText
  {
    get;
    set;
  }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  public uint? DistanceFromLeft
  {
    get;
    set;
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public uint? DistanceFromRight
  {
    get;
    set;
  }
  
  /// <summary>
  /// Wrapping Polygon.
  /// </summary>
  public IWrapPolygon? WrapPolygon
  {
    get;
    set;
  }
  
}
