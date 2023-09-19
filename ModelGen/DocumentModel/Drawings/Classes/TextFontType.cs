namespace DocumentModel.Drawings;


/// <summary>
///   Defines the TextFontType Class.
/// </summary>
public partial class TextFontType
{
  
  /// <summary>
  ///   Text Typeface
  /// </summary>
  [SchemaAttr("typeface")]
  public String? Typeface { get; set; }
  
  
  /// <summary>
  ///   Panose Setting
  /// </summary>
  [SchemaAttr("panose")]
  public DocumentModel.HexBinaryValue? Panose { get; set; }
  
  
  /// <summary>
  ///   Similar Font Family
  /// </summary>
  [SchemaAttr("pitchFamily")]
  public SByte? PitchFamily { get; set; }
  
  
  /// <summary>
  ///   Similar Character Set
  /// </summary>
  [SchemaAttr("charset")]
  public SByte? CharacterSet { get; set; }
  
}
