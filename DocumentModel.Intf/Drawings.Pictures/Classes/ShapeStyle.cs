namespace DocumentModel.Drawings.Pictures;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ShapeStyle Class.
/// </summary>
public class ShapeStyle: ModelElement
{
  /// <summary>
  ///   LineReference.
  /// </summary>
  public LineReference? LineReference { get; set; }

  /// <summary>
  ///   FillReference.
  /// </summary>
  public FillReference? FillReference { get; set; }

  /// <summary>
  ///   EffectReference.
  /// </summary>
  public EffectReference? EffectReference { get; set; }

  /// <summary>
  ///   Font Reference.
  /// </summary>
  public FontReference? FontReference { get; set; }
}