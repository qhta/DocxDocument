namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PtExtension Class.
/// </summary>
public interface PtExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
}
