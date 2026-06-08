namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DocGrid Class.
/// </summary>
public class DocGrid: ModelElement, ISectionPropertiesContent
{
  /// <summary>
  ///   IDocument Grid Type
  /// </summary>
  public DocGridKind? Type { get; set; }

  /// <summary>
  ///   IDocument Grid ILine Pitch
  /// </summary>
  public Twips? LinePitch { get; set; }

  /// <summary>
  ///   IDocument Grid Character Pitch
  /// </summary>
  public Twips? CharacterSpace { get; set; }
}
