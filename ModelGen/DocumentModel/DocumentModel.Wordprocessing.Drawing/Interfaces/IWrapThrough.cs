namespace DocumentModel.Wordprocessing.Drawing;

/// <summary>
/// Through Wrapping.
/// </summary>
public interface IWrapThrough // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public DocumentModel.Wordprocessing.Drawing.WrapTextKind? WrapText { get ; set; }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  public System.UInt32? DistanceFromLeft { get ; set; }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public System.UInt32? DistanceFromRight { get ; set; }
  
  /// <summary>
  /// Wrapping Polygon.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawing.IWrapPolygon? WrapPolygon { get ; set; }
  
}
