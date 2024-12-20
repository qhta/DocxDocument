namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Style Label.
/// </summary>
public class ColorTransformStyleLabel: ModelElement
{
  /// <summary>
  ///   Name
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   Fill Color List.
  /// </summary>
  public FillColorList? FillColorList { get; set; }

  /// <summary>
  ///   Line Color List.
  /// </summary>
  public LineColorList? LineColorList { get; set; }

  /// <summary>
  ///   Effect Color List.
  /// </summary>
  public EffectColorList? EffectColorList { get; set; }

  /// <summary>
  ///   Text Line Color List.
  /// </summary>
  public TextLineColorList? TextLineColorList { get; set; }

  /// <summary>
  ///   Text Fill Color List.
  /// </summary>
  public TextFillColorList? TextFillColorList { get; set; }

  /// <summary>
  ///   Text Effect Color List.
  /// </summary>
  public TextEffectColorList? TextEffectColorList { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}