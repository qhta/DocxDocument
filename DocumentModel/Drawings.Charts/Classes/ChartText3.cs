namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ChartText Class.
/// </summary>
public class ChartText3: ModelElement
{
  /// <summary>
  ///   String Reference.
  /// </summary>
  public StringReference? StringReference { get; set; }

  /// <summary>
  ///   Rich Text.
  /// </summary>
  public RichText? RichText { get; set; }

  /// <summary>
  ///   String Literal.
  /// </summary>
  public StringLiteral? StringLiteral { get; set; }
}