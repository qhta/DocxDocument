namespace DocumentModel.Drawings;

/// <summary>
/// Backdrop Plane.
/// </summary>
public class BackdropImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Backdrop>, Backdrop
{
  /// <summary>
  /// Anchor Point.
  /// </summary>
  public Anchor? Anchor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Normal.
  /// </summary>
  public Boolean? Normal
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
