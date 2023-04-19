namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Color Change Effect.
/// </summary>
public class ColorChange: ModelElement
{
  /// <summary>
  ///   Consider Alpha Values
  /// </summary>
  public bool? UseAlpha { get; set; }

  /// <summary>
  ///   Change Color From.
  /// </summary>
  public ColorFrom? ColorFrom { get; set; }

  /// <summary>
  ///   Change Color To.
  /// </summary>
  public ColorTo? ColorTo { get; set; }
}