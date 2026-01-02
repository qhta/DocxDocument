namespace DocumentModel.Drawings;

/// <summary>
///   Line Spacing.
/// </summary>
public class LineSpacing: ModelElement
{
  public Int32? SpacingPercent { get; set; }
  public Int32? SpacingPoints { get; set; }
}