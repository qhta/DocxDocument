namespace DocumentModel.Drawings;

/// <summary>
/// Color Change Effect.
/// </summary>
public class ColorChange
{
  /// <summary>
  /// Change Color From.
  /// </summary>
  public ColorFrom? ColorFrom
  {
    get;
    set;
  }
  
  /// <summary>
  /// Change Color To.
  /// </summary>
  public ColorTo? ColorTo
  {
    get;
    set;
  }
  
}
