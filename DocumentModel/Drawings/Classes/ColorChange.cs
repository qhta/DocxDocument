namespace DocumentModel.Drawings;

/// <summary>
///   Color Change Effect.
/// </summary>
public record ColorChange
{
  /// <summary>
  ///   Consider Alpha Values
  /// </summary>
  public Boolean? UseAlpha { get; set; }

  /// <summary>
  ///   Change Color From.
  /// </summary>
  public ColorFrom? ColorFrom { get; set; }

  /// <summary>
  ///   Change Color To.
  /// </summary>
  public ColorTo? ColorTo { get; set; }
}