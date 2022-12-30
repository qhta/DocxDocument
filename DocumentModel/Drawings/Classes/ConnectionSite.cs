namespace DocumentModel.Drawings;

/// <summary>
/// Shape Connection Site.
/// </summary>
public partial class ConnectionSite
{
  /// <summary>
  /// Connection Site Angle
  /// </summary>
  public String? Angle { get; set; }
  
  /// <summary>
  /// Position.
  /// </summary>
  public DocumentModel.Drawings.AdjustPoint2DType? Position { get; set; }
  
}
