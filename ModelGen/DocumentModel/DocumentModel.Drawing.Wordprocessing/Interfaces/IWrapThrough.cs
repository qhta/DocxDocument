namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Through Wrapping.
/// </summary>
public interface IWrapThrough // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public WrapTextValues? WrapText { get ; set; }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  public UInt32? DistanceFromLeft { get ; set; }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public UInt32? DistanceFromRight { get ; set; }
  
  /// <summary>
  /// Wrapping Polygon.
  /// </summary>
  public IWrapPolygon? WrapPolygon { get ; set; }
  
}
