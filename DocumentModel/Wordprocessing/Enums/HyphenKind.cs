namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the hyphen enumeration for <see cref="Hyphen"/> element
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum HyphenKind
{
  /// <summary>
  ///   Ascii hyphen that can be treated as minus.
  ///   Code: 002D.
  /// </summary>
  HyphenMinus = 0x02D,

  /// <summary>
  ///   Invisible, optional hypen used for line-breaking.
  ///   Code: 00AD
  /// </summary>
  SoftHyphen = 0x0AD,

  /// <summary>
  ///   Unicode hyphen.
  ///   Code: 2010
  /// </summary>
  Hyphen = 0x2010,

  /// <summary>
  ///   Unicode hyphen which does not break word between lines.
  ///   Code: 2011
  /// </summary>
  NoBreakHyphen = 0x2011,

  /// <summary>
  ///   Unicode dash which has the same width as a numerical digit.
  ///   Code: 2012
  /// </summary>
  FigureDash = 0x2012,

  /// <summary>
  ///   Unicode dash which has traditionally half the width of an em dash.
  ///   Code: 2013
  /// </summary>
  EnDash = 0x2013,

  /// <summary>
  ///   Unicode dash which is one em wide, a length that varies depending on the font size. 
  ///   One em is the same length as the font's height (which is typically measured in points). 
  ///   Code: 2014
  /// </summary>
  EmDash = 0x2014,

  /// <summary>
  ///   Unicode dash also known as a quotation dash, which is used to introduce quoted text. 
  ///   This is the standard method of printing dialogue in some languages. 
  ///   Code: 2014
  /// </summary>
  LongDash = 0x2015,

  /// <summary>
  ///   Unicode small hyphen-minus.
  ///   Code: FE63
  /// </summary>
  SmallHyphenMinus = 0xFE63,

    /// <summary>
  ///   Unicode full-width hyphen-minus
  ///   Code: FF0D
  /// </summary>
  FullWidthHyphenMinus = 0xFD0D,

}