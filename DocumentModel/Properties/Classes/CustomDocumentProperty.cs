namespace DocumentModel.Properties;

/// <summary>
/// Custom File Property.
/// </summary>
public partial class CustomDocumentProperty
{
  /// <summary>
  /// Format ID
  /// </summary>
  public String? FormatId { get; set; }
  
  /// <summary>
  /// Property ID
  /// </summary>
  public Int32? PropertyId { get; set; }
  
  ///// <summary>
  ///// Custom File Property Name
  ///// </summary>
  //public String? Name { get; set; }
  
  /// <summary>
  /// Bookmark Link Target
  /// </summary>
  public String? LinkTarget { get; set; }
  
  /// <summary>
  /// Vector.
  /// </summary>
  public DocumentModel.VectorVariant? VTVector { get; set; }
  
  /// <summary>
  /// Array.
  /// </summary>
  public DocumentModel.ArrayVariant? VTArray { get; set; }
  
  /// <summary>
  /// Binary Blob.
  /// </summary>
  public String? VTBlob { get; set; }
  
  /// <summary>
  /// Binary Blob Object.
  /// </summary>
  public String? VTOBlob { get; set; }
  
  /// <summary>
  /// Empty.
  /// </summary>
  public Boolean? VTEmpty { get; set; }
  
  /// <summary>
  /// Null.
  /// </summary>
  public Boolean? VTNull { get; set; }
  
  /// <summary>
  /// 1-Byte Signed Integer.
  /// </summary>
  public String? VTByte { get; set; }
  
  /// <summary>
  /// 2-Byte Signed Integer.
  /// </summary>
  public String? VTShort { get; set; }
  
  /// <summary>
  /// 4-Byte Signed Integer.
  /// </summary>
  public String? VTInt32 { get; set; }
  
  /// <summary>
  /// 8-Byte Signed Integer.
  /// </summary>
  public String? VTInt64 { get; set; }
  
  /// <summary>
  /// Integer.
  /// </summary>
  public String? VTInteger { get; set; }
  
  /// <summary>
  /// 1-Byte Unsigned Integer.
  /// </summary>
  public String? VTUnsignedByte { get; set; }
  
  /// <summary>
  /// 2-Byte Unsigned Integer.
  /// </summary>
  public String? VTUnsignedShort { get; set; }
  
  /// <summary>
  /// 4-Byte Unsigned Integer.
  /// </summary>
  public String? VTUnsignedInt32 { get; set; }
  
  /// <summary>
  /// 8-Byte Unsigned Integer.
  /// </summary>
  public String? VTUnsignedInt64 { get; set; }
  
  /// <summary>
  /// Unsigned Integer.
  /// </summary>
  public String? VTUnsignedInteger { get; set; }
  
  /// <summary>
  /// 4-Byte Real Number.
  /// </summary>
  public String? VTFloat { get; set; }
  
  /// <summary>
  /// 8-Byte Real Number.
  /// </summary>
  public String? VTDouble { get; set; }
  
  /// <summary>
  /// Decimal.
  /// </summary>
  public String? VTDecimal { get; set; }
  
  /// <summary>
  /// LPSTR.
  /// </summary>
  public String? VTLPSTR { get; set; }
  
  /// <summary>
  /// LPWSTR.
  /// </summary>
  public String? VTLPWSTR { get; set; }
  
  /// <summary>
  /// Basic String.
  /// </summary>
  public String? VTBString { get; set; }
  
  /// <summary>
  /// Date and Time.
  /// </summary>
  public String? VTDate { get; set; }
  
  /// <summary>
  /// File Time.
  /// </summary>
  public String? VTFileTime { get; set; }
  
  /// <summary>
  /// Boolean.
  /// </summary>
  public String? VTBool { get; set; }
  
  /// <summary>
  /// Currency.
  /// </summary>
  public String? VTCurrency { get; set; }
  
  /// <summary>
  /// Error Status Code.
  /// </summary>
  public String? VTError { get; set; }
  
  /// <summary>
  /// Binary Stream.
  /// </summary>
  public String? VTStreamData { get; set; }
  
  /// <summary>
  /// Binary Stream Object.
  /// </summary>
  public String? VTOStreamData { get; set; }
  
  /// <summary>
  /// Binary Storage.
  /// </summary>
  public String? VTStorage { get; set; }
  
  /// <summary>
  /// Binary Storage Object.
  /// </summary>
  public String? VTOStorage { get; set; }
  
  /// <summary>
  /// Binary Versioned Stream.
  /// </summary>
  public DocumentModel.VariantTypes.VTVStreamData? VTVStreamData { get; set; }
  
  /// <summary>
  /// Class ID.
  /// </summary>
  public String? VTClassId { get; set; }
  
  /// <summary>
  /// Clipboard Data.
  /// </summary>
  public DocumentModel.VariantTypes.VTClipboardData? VTClipboardData { get; set; }
  
}
