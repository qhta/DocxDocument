namespace DocumentModel.Office2019.Drawing.SVG;

/// <summary>
/// Defines the SVGBlip Class.
/// </summary>
public class SVGBlip: ISVGBlip
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  public string? Embed
  {
    get;
    set;
  }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  public string? Link
  {
    get;
    set;
  }
  
}
