namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Format Scheme.
/// </summary>
public class FormatScheme: ModelElement
{
  /// <summary>
  ///   Name
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   Fill Style List.
  /// </summary>
  public FillStyleList? FillStyleList { get; set; }

  /// <summary>
  ///   Line Style List.
  /// </summary>
  public LineStyleList? LineStyleList { get; set; }

  /// <summary>
  ///   Effect Style List.
  /// </summary>
  public EffectStyleList? EffectStyleList { get; set; }

  /// <summary>
  ///   Background Fill Style List.
  /// </summary>
  public BackgroundFillStyleList? BackgroundFillStyleList { get; set; }
}