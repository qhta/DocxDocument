namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FontSignature Class.
/// </summary>
public partial class FontSignature
{
  
  /// <summary>
  ///   First 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [SchemaAttr("w:usb0")]
  public DocumentModel.HexBinaryValue? UnicodeSignature0 { get; set; }
  
  
  /// <summary>
  ///   Second 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [SchemaAttr("w:usb1")]
  public DocumentModel.HexBinaryValue? UnicodeSignature1 { get; set; }
  
  
  /// <summary>
  ///   Third 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [SchemaAttr("w:usb2")]
  public DocumentModel.HexBinaryValue? UnicodeSignature2 { get; set; }
  
  
  /// <summary>
  ///   Fourth 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [SchemaAttr("w:usb3")]
  public DocumentModel.HexBinaryValue? UnicodeSignature3 { get; set; }
  
  
  /// <summary>
  ///   Lower 32 Bits of Code Page Bit Field
  /// </summary>
  [SchemaAttr("w:csb0")]
  public DocumentModel.HexBinaryValue? CodePageSignature0 { get; set; }
  
  
  /// <summary>
  ///   Upper 32 Bits of Code Page Bit Field
  /// </summary>
  [SchemaAttr("w:csb1")]
  public DocumentModel.HexBinaryValue? CodePageSignature1 { get; set; }
  
}
