namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PtExtension Class.
/// </summary>
public interface PtExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings.Diagrams.NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
}
