namespace DocumentModel.Drawings.SVG;

/// <summary>
/// Defines the SVGBlip Class.
/// </summary>
public interface SVGBlip
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  public String? Embed { get ; set; }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  public String? Link { get ; set; }
  
}
