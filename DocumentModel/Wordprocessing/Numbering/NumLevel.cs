namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the appearance and behavior of a numbering level within a given abstract numbering definition. 
///   A numbering level contains a set of properties for the display of the numbering for a given numbering level 
///   within an abstract numbering definition.
/// </summary>
/// <remarks>
///   A numbering level definition is identical to a numbering level override definition, 
///   except for the fact that it is defined as part of a numbering definition instance using the  abstractNum element (§17.9.1) 
///   rather than as part of an abstract numbering definition using the num element (§17.9.15).
/// </remarks>
public class NumLevel: ModelElement
{

  /// <summary>
  ///   Specifies the numbering level definition that is to be defined by this set of numbering properties.  
  ///   It is a zero-based index of the number of list levels in the document. 
  ///   [Example: A value of 2 is the 3rd list level in the document. end example] 
  /// </summary>
  public Int32? LevelIndex { get; set; }

  /// <summary>
  ///   Specifies that a given numbering level was been saved by a producer but was not used in the parent document. 
  ///   This means that this numbering level can be redefined by a future consumer without changing the actual content of the document. 
  /// </summary>
  public Boolean? Tentative { get; set; }

  /// <summary>
  ///   This element specifies the starting value for the numbering 
  ///   used by the parent numbering level within a given numbering level definition. 
  ///   This value is used when this level initially starts in a document, 
  ///   as well as whenever it is restarted via the properties set in the lvlRestart element (§17.9.10).  
  ///   If this element is omitted, then the starting value shall be zero (0).
  /// </summary>
  public Int32? StartNumberingValue { get; set; }

  /// <summary>
  ///  Specifies a one-based index which determines when a numbering level should restart to its start value. 
  ///  A numbering level restarts when an instance of the specified numbering level, 
  ///  which shall be higher (earlier than this level) or any earlier level is used in the given document's contents. 
  ///  [Example: If this value is 2, then both level two and level one reset this value. end example] 
  /// </summary>
  public Int32? LevelRestart { get; set; }

  /// <summary>
  ///   Specifies the number format that shall be used to display all numbering at this level in the numbering definition. 
  ///   This information is used to replace the level text string %x, where x is a particular onebased level index, 
  ///   with the appropriate value unless the numFmt value is bullet, in which case the literal text of the level text string is used. 
  ///   This value shall be calculated by counting the number of paragraphs at this level 
  ///   since the last restart using the numbering system defined in the val attribute. 
  /// </summary>
  public NumberingFormat? NumberingFormat { get; set; }

  /// <summary>
  ///   Paragraph Style's Associated Numbering Level.
  /// </summary>
  public String? ParagraphStyleIdInLevel { get; set; }

  /// <summary>
  ///   Display All Levels Using Arabic Numerals.
  /// </summary>
  public Boolean? IsLegalNumberingStyle { get; set; }

  /// <summary>
  ///   Specifies the content which shall be added between a given numbering level's text 
  ///   and the text of every numbered paragraph which references that numbering level. 
  ///   If this element is omitted, then its value shall be assumed to be tab.
  /// </summary>
  public LevelSuffixKind? LevelSuffix { get; set; }

  /// <summary>
  ///   Specifies the textual content which shall be displayed when displaying a paragraph with the given numbering level. 
  ///   All text in this element's val attribute shall be taken as literal text to be repeated in each instance of this numbering level, 
  ///   except for any use of the percent symbol (%) followed by a number, 
  ///   which shall be used to indicate the one-based index of the number to be used at this level. 
  ///   Any number of a level higher than this level shall be ignored. 
  ///   When the % syntax is used, the number shall be incremented for each subsequent paragraph of that level (sequential or not), 
  ///   until the restart level is seen between two subsequent paragraphs of this level. 
  /// </summary>
  public NumLevelText? LevelText { get; set; }

  /// <summary>
  ///   Specifies the appearance and behavior of a specific picture to be used 
  ///   as the numbering symbol within a numbering level definition in a document, 
  ///   and is the basis for all picture numbering symbol information in a WordprocessingML document.  
  ///   This element is not used directly within abstract numbering definitions but rather is referenced 
  ///   through its numPicBulletId attribute by the lvlPicBulletId element (§17.9.9) used within numbering level definitions.
  /// </summary>
  public Int32? LevelPictureBulletId { get; set; }

  /// <summary>
  ///   Specifies a unique hexadecimal value which can be used to specify a location within an application's user interface 
  ///   in which this numbering level shall be displayed. The method by which this value is interpreted shall be application-defined. 
  /// </summary>
  public HexInt? TemplateCode { get; set; }

  /// <summary>
  ///   Specifies that a given numbering level is from an earlier word processing application 
  ///   which did not support the full richness of the numbering properties supported by WordprocessingML.
  /// </summary>
  public LegacyNumbering? LegacyNumbering { get; set; }

  /// <summary>
  ///   Justification.
  /// </summary>
  public LevelJustificationKind? LevelJustification { get; set; }

  /// <summary>
  ///   Numbering Level Associated Paragraph Properties.
  /// </summary>
  public PreviousParagraphProperties? PreviousParagraphProperties { get; set; }

  /// <summary>
  ///   Numbering Symbol Run Properties.
  /// </summary>
  public NumberingSymbolRunProperties? NumberingSymbolRunProperties { get; set; }
}