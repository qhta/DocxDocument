namespace DocumentModel.Drawing;

/// <summary>
/// Shape Connection Site.
/// </summary>
public interface IConnectionSite // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Connection Site Angle
  /// </summary>
  public String? Angle { get ; set; }
  
  /// <summary>
  /// Position.
  /// </summary>
  public IPosition? Position { get ; set; }
  
}
