namespace DocumentModel.Drawings;

/// <summary>
///   Extra Color Scheme.
/// </summary>
public interface ExtraColorScheme: IModelElement
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