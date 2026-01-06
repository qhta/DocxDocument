namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the textual content which shall be displayed when displaying a paragraph with the given numbering level. 
///   All text in this element's val attribute shall be taken as literal text to be repeated in each instance of this numbering level, 
///   except for any use of the percent symbol (%) followed by a number, 
///   which shall be used to indicate the one-based index of the number to be used at this level. 
///   Any number of a level higher than this level shall be ignored. 
///   When the % syntax is used, the number shall be incremented for each subsequent paragraph of that level (sequential or not), 
///   until the restart level is seen between two subsequent paragraphs of this level. 
/// </summary>
public interface NumLevelText
{
  /// <summary>
  ///   Level Text
  /// </summary>
  public string? Text { get; set; }

  /// <summary>
  ///   Level Text Is Null Character
  /// </summary>
  public Boolean IsNull { get; set; }
}