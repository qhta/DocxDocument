namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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