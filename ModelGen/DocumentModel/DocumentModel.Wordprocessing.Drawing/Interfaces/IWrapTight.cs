namespace DocumentModel.Wordprocessing.Drawing;

/// <summary>
/// Tight Wrapping.
/// </summary>
public interface IWrapTight // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public DocumentModel.Wordprocessing.Drawing.WrapTextKind? WrapText { get ; set; }
  
  /// <summary>
  /// Distance From Test on Left Edge
  /// </summary>
  public System.UInt32? DistanceFromLeft { get ; set; }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public System.UInt32? DistanceFromRight { get ; set; }
  
  /// <summary>
  /// Tight Wrapping Extents Polygon.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawing.IWrapPolygon? WrapPolygon { get ; set; }
  
}
