namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the StylisticSets Class.
/// </summary>
public class StylisticSets: ModelElement
{
  public Collection<StyleSet>? StyleSets { get; set; }
}