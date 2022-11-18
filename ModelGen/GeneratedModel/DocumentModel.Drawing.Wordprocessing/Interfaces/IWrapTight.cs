namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Tight Wrapping.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IWrapPolygon))]
public interface IWrapTight // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public WrapText? WrapText { get ; set; }
  
  /// <summary>
  /// Distance From Test on Left Edge
  /// </summary>
  public uint? DistanceFromLeft { get ; set; }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public uint? DistanceFromRight { get ; set; }
  
  /// <summary>
  /// Tight Wrapping Extents Polygon.
  /// </summary>
  public IWrapPolygon? WrapPolygon { get ; set; }
  
}
