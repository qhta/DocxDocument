namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Tab Stop.
/// </summary>
public class TabStop: ModelElement
{
  /// <summary>
  ///   Tab Position
  /// </summary>
  public Int32? Position { get; set; }

  /// <summary>
  ///   Tab Alignment
  /// </summary>
  public TextTabAlignmentKind? Alignment { get; set; }
}