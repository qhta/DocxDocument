namespace DocumentModel.Drawings;

/// <summary>
///   Space Before.
/// </summary>
public record SpaceBefore
{
  public Int32? SpacingPercent { get; set; }

  public Int32? SpacingPoints { get; set; }
}