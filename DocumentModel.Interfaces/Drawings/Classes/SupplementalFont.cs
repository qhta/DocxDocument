namespace DocumentModel.Drawings;

/// <summary>
///   Font.
/// </summary>
public interface SupplementalFont:
{
  /// <summary>
  ///   Script
  /// </summary>
  public string? Script { get; set; }
  /// <summary>
  ///   Typeface
  /// </summary>
  public string? Typeface { get; set; }
}