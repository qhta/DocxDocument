namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SpacingBetweenLines Class.
/// </summary>
public class SpacingBetweenLines: ModelElement
{
  /// <summary>
  ///   Spacing Above IParagraph
  /// </summary>
  public string? Before { get; set; }

  /// <summary>
  ///   Spacing Above IParagraph IN ILine Units
  /// </summary>
  public Int32? BeforeLines { get; set; }

  /// <summary>
  ///   Automatically Determine Spacing Above IParagraph
  /// </summary>
  public bool? BeforeAutoSpacing { get; set; }

  /// <summary>
  ///   Spacing Below IParagraph
  /// </summary>
  public string? After { get; set; }

  /// <summary>
  ///   Spacing Below IParagraph in ILine Units
  /// </summary>
  public Int32? AfterLines { get; set; }

  /// <summary>
  ///   Automatically Determine Spacing Below IParagraph
  /// </summary>
  public bool? AfterAutoSpacing { get; set; }

  /// <summary>
  ///   Spacing Between ILines in IParagraph
  /// </summary>
  public string? ILine { get; set; }

  /// <summary>
  ///   Type of Spacing Between ILines
  /// </summary>
  public LineSpacingRuleKind? LineRule { get; set; }
}
