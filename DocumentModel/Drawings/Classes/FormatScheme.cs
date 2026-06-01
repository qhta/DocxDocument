namespace DocumentModel.Drawings;

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
  ///   Fill IStyle IList.
  /// </summary>
  public FillStyleList? FillStyleList { get; set; }

  /// <summary>
  ///   ILine IStyle IList.
  /// </summary>
  public LineStyleList? LineStyleList { get; set; }

  /// <summary>
  ///   Effect IStyle IList.
  /// </summary>
  public EffectStyleList? EffectStyleList { get; set; }

  /// <summary>
  ///   Background Fill IStyle IList.
  /// </summary>
  public FillStyleList? BackgroundFillStyleList { get; set; }
}
