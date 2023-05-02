namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Line Spacing.
/// </summary>
public class LineSpacing: ModelElement
{
  public Int32? SpacingPercent { get; set; }

  public Int32? SpacingPoints { get; set; }
}