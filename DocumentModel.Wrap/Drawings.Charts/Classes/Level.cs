namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Level.
/// </summary>
public class Level: ModelElement
{
  public Collection<StringPoint>? StringPoints { get; set; }
}