namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the EastAsianLayout Class.
/// </summary>
public record EastAsianLayout
{
  /// <summary>
  ///   East Asian Typography Run ID
  /// </summary>
  public Int32? Id { get; set; }

  /// <summary>
  ///   Two Lines in One
  /// </summary>
  public Boolean? Combine { get; set; }

  /// <summary>
  ///   Display Brackets Around Two Lines in One
  /// </summary>
  public CombineBracketKind? CombineBrackets { get; set; }

  /// <summary>
  ///   Horizontal in Vertical (Rotate Text)
  /// </summary>
  public Boolean? Vertical { get; set; }

  /// <summary>
  ///   Compress Rotated Text to Line Height
  /// </summary>
  public Boolean? VerticalCompress { get; set; }
}