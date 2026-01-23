namespace DocumentModel.Drawings;

/// <summary>
///   Represents a supplemental font for a specific script, including script identifier and typeface.
/// </summary>
public class SupplementalFont: ModelElement<DXD.SupplementalFont>
{
  /// <summary>
  ///   Script identifier for which the font is used.
  /// </summary>
  public string? Script { get; set; }

  /// <summary>
  ///   Typeface name for the specified script.
  /// </summary>
  public string? Typeface { get; set; }
}