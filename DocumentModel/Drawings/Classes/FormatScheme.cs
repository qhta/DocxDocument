namespace DocumentModel.Drawings;

/// <summary>
///   Format Scheme.
/// </summary>
public class FormatScheme: ModelElement
{
  /// <summary>
  ///   Name
  /// </summary>
  public String? Name { get; set; }

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