namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a color using the red, green, blue RGB color model. Red, green, and blue is expressed as sequence of hex digits, RRGGBB. A perceptual gamma of 2.2 is used.
/// </summary>
public partial class RgbColorModelHex
{
  
  /// <summary>
  ///   The actual color value. Expressed as a sequence of hex digits RRGGBB.
  /// </summary>
  [SchemaAttr("val")]
  public DocumentModel.HexBinaryValue? Val { get; set; }
  
  
  /// <summary>
  ///   legacySpreadsheetColorIndex, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("a14:legacySpreadsheetColorIndex")]
  public Int32? LegacySpreadsheetColorIndex { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
