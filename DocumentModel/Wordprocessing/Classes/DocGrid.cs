namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DocGrid Class.
/// </summary>
public class DocGrid: ModelElement, ISectionPropertiesElement
{
  /// <summary>
  ///   Document Grid Type
  /// </summary>
  public DocGridKind? Type { get; set; }

  /// <summary>
  ///   Document Grid Line Pitch
  /// </summary>
  public Twips? LinePitch { get; set; }

  /// <summary>
  ///   Document Grid Character Pitch
  /// </summary>
  public Twips? CharacterSpace { get; set; }
}