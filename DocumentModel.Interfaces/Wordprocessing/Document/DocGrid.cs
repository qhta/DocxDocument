namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the DocGrid Class.
/// </summary>
public class DocGrid: ModelElement, ISectionPropertiesContent
{
  /// <summary>
  ///   Document Grid Type
  /// </summary>
  public DocGridKind? Type { get; set; }
  /// <summary>
  ///   Document Grid Line Pitch
  /// </summary>
  public ITwips? LinePitch { get; set; }
  /// <summary>
  ///   Document Grid Character Pitch
  /// </summary>
  public ITwips? CharacterSpace { get; set; }
}