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
  
  public NonVisualDrawingProperties1? NonVisualDrawingProperties { get ; set; }
  
}
