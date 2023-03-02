namespace DocumentModel.Drawings;

/// <summary>
///   Extra Color Scheme.
/// </summary>
public record ExtraColorScheme
{
  /// <summary>
  ///   ColorScheme.
  /// </summary>
  public ColorScheme? ColorScheme { get; set; }

  /// <summary>
  ///   ColorMap.
  /// </summary>
  public ColorMap? ColorMap { get; set; }
}