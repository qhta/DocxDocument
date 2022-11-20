namespace DocumentModel.Wordprocessing;

/// <summary>
/// Character-Level Whitespace Compression.
/// </summary>
public class CharacterSpacingControl: ICharacterSpacingControl
{
  /// <summary>
  /// Value
  /// </summary>
  public CharacterSpacingValues? Val
  {
    get;
    set;
  }
  
}
