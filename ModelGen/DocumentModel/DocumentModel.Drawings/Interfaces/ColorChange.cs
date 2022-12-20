namespace DocumentModel.Drawings;

/// <summary>
/// Color Change Effect.
/// </summary>
public partial interface ColorChange
{
  /// <summary>
  /// Consider Alpha Values
  /// </summary>
  public Boolean? UseAlpha { get; set; }
  
  /// <summary>
  /// Change Color From.
  /// </summary>
  public DocumentModel.Drawings.ColorFrom? ColorFrom { get; set; }
  
  /// <summary>
  /// Change Color To.
  /// </summary>
  public DocumentModel.Drawings.ColorTo? ColorTo { get; set; }
  
}
