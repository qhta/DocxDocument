namespace DocumentModel.Office2019.Drawing.SVG;

/// <summary>
/// Defines the SVGBlip Class.
/// </summary>
public interface ISVGBlip // : DocumentModel.ITypedOpenXmlLeafElement
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
