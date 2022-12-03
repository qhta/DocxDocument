namespace DocumentModel.Drawings;

/// <summary>
/// Color Change Effect.
/// </summary>
public interface ColorChange // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Consider Alpha Values
  /// </summary>
  public Boolean? UseAlpha { get ; set; }
  
  /// <summary>
  /// Change Color From.
  /// </summary>
  public ColorFrom? ColorFrom { get ; set; }
  
  /// <summary>
  /// Change Color To.
  /// </summary>
  public ColorTo? ColorTo { get ; set; }
  
}
