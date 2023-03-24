namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LineNumberType Class.
/// </summary>
public class LineNumberType: ModelElement, ISectionPropertiesElement
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