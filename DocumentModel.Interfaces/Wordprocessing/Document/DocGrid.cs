namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the DocGrid Class.
/// </summary>
public interface DocGrid: IModelElement, ISectionPropertiesContent
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