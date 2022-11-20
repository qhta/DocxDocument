namespace DocumentModel.Drawing;

/// <summary>
/// Shape Connection Site.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IPosition))]
public class ConnectionSite: IConnectionSite
{
  /// <summary>
  /// Connection Site Angle
  /// </summary>
  public string? Angle
  {
    get;
    set;
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  public DocumentModel.Drawing.IPosition? Position
  {
    get;
    set;
  }
  
}
