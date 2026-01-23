namespace DocumentModel.Drawings;

/// <summary>
///   Represents a tab stop in text, including its position and alignment.
/// </summary>
public class TabStop: ModelElement<DXD.TabStop>
{
  /// <summary>
  ///   Position of the tab stop.
  /// </summary>
  public Int32? Position { get; set; }

  /// <summary>
  ///   Alignment type for the tab stop.
  /// </summary>
  public TextTabAlignmentKind? Alignment { get; set; }
}