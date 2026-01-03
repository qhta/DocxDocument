namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the StylisticSets Class.
/// </summary>
public interface StylisticSets: IModelElement
{
  public Collection<StyleSet>? StyleSets { get; set; }
}