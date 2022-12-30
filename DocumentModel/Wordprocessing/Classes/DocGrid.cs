namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DocGrid Class.
/// </summary>
public partial class DocGrid
{
  /// <summary>
  /// Document Grid Type
  /// </summary>
  public DocumentModel.Wordprocessing.DocGridKind? Type { get; set; }
  
  /// <summary>
  /// Document Grid Line Pitch
  /// </summary>
  public Int32? LinePitch { get; set; }
  
  /// <summary>
  /// Document Grid Character Pitch
  /// </summary>
  public Int32? CharacterSpace { get; set; }
  
}
