namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IStyle Label.
/// </summary>
public class ColorTransformStyleLabel: ModelElement
{
  /// <summary>
  ///   Name
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   Fill Color IList.
  /// </summary>
  public FillColorList? FillColorList { get; set; }

  /// <summary>
  ///   ILine Color IList.
  /// </summary>
  public LineColorList? LineColorList { get; set; }

  /// <summary>
  ///   Effect Color IList.
  /// </summary>
  public EffectColorList? EffectColorList { get; set; }

  /// <summary>
  ///   Text ILine Color IList.
  /// </summary>
  public TextLineColorList? TextLineColorList { get; set; }

  /// <summary>
  ///   Text Fill Color IList.
  /// </summary>
  public TextFillColorList? TextFillColorList { get; set; }

  /// <summary>
  ///   Text Effect Color IList.
  /// </summary>
  public TextEffectColorList? TextEffectColorList { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}
