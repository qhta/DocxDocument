namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Space Before.
/// </summary>
public class SpaceBefore: ModelElement
{
  public Int32? SpacingPercent { get; set; }

  public Int32? SpacingPoints { get; set; }
}
