namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the StylisticSets Class.
/// </summary>
public record StylisticSets
{
  public Collection<StyleSet>? StyleSets { get; set; }
}