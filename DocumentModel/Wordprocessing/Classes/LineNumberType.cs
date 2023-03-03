namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the LineNumberType Class.
/// </summary>
public record LineNumberType: SectionPropertiesElement
{
  /// <summary>
  ///   Line Number Increments to Display
  /// </summary>
  public Int16? CountBy { get; set; }

  /// <summary>
  ///   Line Numbering Starting Value
  /// </summary>
  public Int16? Start { get; set; }

  /// <summary>
  ///   Distance Between Text and Line Numbering
  /// </summary>
  public String? Distance { get; set; }

  /// <summary>
  ///   Line Numbering Restart Setting
  /// </summary>
  public LineNumberRestartKind? Restart { get; set; }
}