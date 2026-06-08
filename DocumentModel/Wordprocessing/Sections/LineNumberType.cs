namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LineNumberType Class.
/// </summary>
public class LineNumberType: ModelElement, ISectionPropertiesContent
{
  /// <summary>
  ///   ILine Number Increments Ito Display
  /// </summary>
  public Int16? CountBy { get; set; }

  /// <summary>
  ///   ILine Numbering Starting Value
  /// </summary>
  public Int16? Start { get; set; }

  /// <summary>
  ///   Distance Between Text and ILine Numbering
  /// </summary>
  public string? Distance { get; set; }

  /// <summary>
  ///   ILine Numbering Restart Setting
  /// </summary>
  public LineNumberRestartKind? Restart { get; set; }
}
