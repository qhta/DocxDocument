namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextCharacterPropertiesType Class.
/// </summary>
public class TextCharacterPropertiesType2
{
  /// <summary>
  /// u
  /// </summary>
  public TextUnderlineKind? Underline
  {
    get;
    set;
  }
  
  /// <summary>
  /// strike
  /// </summary>
  public TextStrikeKind? Strike
  {
    get;
    set;
  }
  
  /// <summary>
  /// cap
  /// </summary>
  public TextCapsKind? Capital
  {
    get;
    set;
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public virtual Outline? Outline
  {
    get;
    set;
  }
  
}
