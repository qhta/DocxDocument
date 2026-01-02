namespace DocumentModel.Drawings;

/// <summary>
///   Extra Color Scheme.
/// </summary>
public class ExtraColorScheme: ModelElement
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