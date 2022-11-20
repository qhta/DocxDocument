namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DocGrid Class.
/// </summary>
public class DocGrid: IDocGrid
{
  /// <summary>
  /// Document Grid Type
  /// </summary>
  public DocGridValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Document Grid Line Pitch
  /// </summary>
  public int? LinePitch
  {
    get;
    set;
  }
  
  /// <summary>
  /// Document Grid Character Pitch
  /// </summary>
  public int? CharacterSpace
  {
    get;
    set;
  }
  
}
