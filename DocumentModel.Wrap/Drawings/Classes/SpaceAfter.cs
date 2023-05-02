namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Space After.
/// </summary>
public class SpaceAfter: ModelElement
{
  public Int32? SpacingPercent { get; set; }

  public Int32? SpacingPoints { get; set; }
}