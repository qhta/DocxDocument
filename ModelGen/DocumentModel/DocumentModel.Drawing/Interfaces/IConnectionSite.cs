namespace DocumentModel.Drawing;

/// <summary>
/// Shape Connection Site.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IPosition))]
public interface IConnectionSite // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Connection Site Angle
  /// </summary>
  public string? Angle { get ; set; }
  
  /// <summary>
  /// Position.
  /// </summary>
  public DocumentModel.Drawing.IPosition? Position { get ; set; }
  
}
