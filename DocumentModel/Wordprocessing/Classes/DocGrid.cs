namespace DocumentModel.Wordprocessing;

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
  public DXA? LinePitch { get; set; }

  /// <summary>
  ///   Document Grid Character Pitch
  /// </summary>
  public DXA? CharacterSpace { get; set; }
}