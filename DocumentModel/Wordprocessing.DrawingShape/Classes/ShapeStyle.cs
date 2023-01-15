using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.DrawingShape;

/// <summary>
///   Defines the ShapeStyle Class.
/// </summary>
public class ShapeStyle
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