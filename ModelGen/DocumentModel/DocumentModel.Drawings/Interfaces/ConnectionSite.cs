namespace DocumentModel.Drawings;

/// <summary>
/// Shape Connection Site.
/// </summary>
public interface ConnectionSite // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Connection Site Angle
  /// </summary>
  public String? Angle { get ; set; }
  
  /// <summary>
  /// Position.
  /// </summary>
  public AdjustPoint2DType? Position { get ; set; }
  
}
