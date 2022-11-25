namespace DocumentModel.Drawing;

/// <summary>
/// Shape Connection Site.
/// </summary>
public interface IConnectionSite // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Connection Site Angle
  /// </summary>
  public System.String? Angle { get ; set; }
  
  /// <summary>
  /// Position.
  /// </summary>
  public DocumentModel.Drawing.IAdjustPoint2DType? Position { get ; set; }
  
}
