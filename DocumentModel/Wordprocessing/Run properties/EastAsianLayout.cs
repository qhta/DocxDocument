namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the EastAsianLayout Class.
/// </summary>
public class EastAsianLayout: ModelElement
{
  /// <summary>
  ///   East Asian Typography Run ID
  /// </summary>
  public Int32? Id { get; set; }

  /// <summary>
  ///   Two Lines in One
  /// </summary>
  public bool? Combine { get; set; }

  /// <summary>
  ///   Display Brackets Around Two Lines in One
  /// </summary>
  public CombineBracketKind? CombineBrackets { get; set; }

  /// <summary>
  ///   Horizontal in Vertical (Rotate Text)
  /// </summary>
  public bool? Vertical { get; set; }

  /// <summary>
  ///   Compress Rotated Text to Line Height
  /// </summary>
  public bool? VerticalCompress { get; set; }
}