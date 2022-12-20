namespace DocumentModel.Properties;

/// <summary>
/// Custom File Property.
/// </summary>
public partial interface CustomDocumentProperty
{
  /// <summary>
  /// Format ID
  /// </summary>
  public String? FormatId { get; set; }
  
  /// <summary>
  /// Property ID
  /// </summary>
  public Int32? PropertyId { get; set; }
  
  /// <summary>
  /// Custom File Property Name
  /// </summary>
  public String? Name { get; set; }
  
  /// <summary>
  /// Bookmark Link Target
  /// </summary>
  public String? LinkTarget { get; set; }
  
  /// <summary>
  /// Vector.
  /// </summary>
  public DocumentModel.VariantTypes.VTVector? VTVector { get; set; }
  
  /// <summary>
  /// Array.
  /// </summary>
  public DocumentModel.VariantTypes.VTArray? VTArray { get; set; }
  
  /// <summary>
  /// Binary Blob.
  /// </summary>
  public DocumentModel.VariantTypes.VTBlob? VTBlob { get; set; }
  
  /// <summary>
  /// Binary Blob Object.
  /// </summary>
  public DocumentModel.VariantTypes.VTBlob? VTOBlob { get; set; }
  
  /// <summary>
  /// Empty.
  /// </summary>
  public DocumentModel.VariantTypes.VTEmpty? VTEmpty { get; set; }
  
  /// <summary>
  /// Null.
  /// </summary>
  public DocumentModel.VariantTypes.VTNull? VTNull { get; set; }
  
  /// <summary>
  /// 1-Byte Signed Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTSignedByte? VTByte { get; set; }
  
  /// <summary>
  /// 2-Byte Signed Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTShort? VTShort { get; set; }
  
  /// <summary>
  /// 4-Byte Signed Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTInt32? VTInt32 { get; set; }
  
  /// <summary>
  /// 8-Byte Signed Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTInt64? VTInt64 { get; set; }
  
  /// <summary>
  /// Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTInt64? VTInteger { get; set; }
  
  /// <summary>
  /// 1-Byte Unsigned Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTByte? VTUnsignedByte { get; set; }
  
  /// <summary>
  /// 2-Byte Unsigned Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTUnsignedShort? VTUnsignedShort { get; set; }
  
  /// <summary>
  /// 4-Byte Unsigned Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTUnsignedInt32? VTUnsignedInt32 { get; set; }
  
  /// <summary>
  /// 8-Byte Unsigned Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTUnsignedInt64? VTUnsignedInt64 { get; set; }
  
  /// <summary>
  /// Unsigned Integer.
  /// </summary>
  public DocumentModel.VariantTypes.VTUnsignedInt64? VTUnsignedInteger { get; set; }
  
  /// <summary>
  /// 4-Byte Real Number.
  /// </summary>
  public DocumentModel.VariantTypes.VTFloat? VTFloat { get; set; }
  
  /// <summary>
  /// 8-Byte Real Number.
  /// </summary>
  public DocumentModel.VariantTypes.VTDouble? VTDouble { get; set; }
  
  /// <summary>
  /// Decimal.
  /// </summary>
  public DocumentModel.VariantTypes.VTDecimal? VTDecimal { get; set; }
  
  /// <summary>
  /// LPSTR.
  /// </summary>
  public DocumentModel.VariantTypes.VTString? VTLPSTR { get; set; }
  
  /// <summary>
  /// LPWSTR.
  /// </summary>
  public DocumentModel.VariantTypes.VTString? VTLPWSTR { get; set; }
  
  /// <summary>
  /// Basic String.
  /// </summary>
  public DocumentModel.VariantTypes.VTString? VTBString { get; set; }
  
  /// <summary>
  /// Date and Time.
  /// </summary>
  public DocumentModel.VariantTypes.VTDate? VTDate { get; set; }
  
  /// <summary>
  /// File Time.
  /// </summary>
  public DocumentModel.VariantTypes.VTDateTime? VTFileTime { get; set; }
  
  /// <summary>
  /// Boolean.
  /// </summary>
  public String? VTBool { get; set; }
  
  /// <summary>
  /// Currency.
  /// </summary>
  public DocumentModel.VariantTypes.VTCurrency? VTCurrency { get; set; }
  
  /// <summary>
  /// Error Status Code.
  /// </summary>
  public DocumentModel.VariantTypes.VTError? VTError { get; set; }
  
  /// <summary>
  /// Binary Stream.
  /// </summary>
  public DocumentModel.VariantTypes.VTStream? VTStreamData { get; set; }
  
  /// <summary>
  /// Binary Stream Object.
  /// </summary>
  public DocumentModel.VariantTypes.VTStream? VTOStreamData { get; set; }
  
  /// <summary>
  /// Binary Storage.
  /// </summary>
  public DocumentModel.VariantTypes.VTStorage? VTStorage { get; set; }
  
  /// <summary>
  /// Binary Storage Object.
  /// </summary>
  public DocumentModel.VariantTypes.VTStorage? VTOStorage { get; set; }
  
  /// <summary>
  /// Binary Versioned Stream.
  /// </summary>
  public DocumentModel.VariantTypes.VTVStream? VTVStreamData { get; set; }
  
  /// <summary>
  /// Class ID.
  /// </summary>
  public DocumentModel.VariantTypes.VTClassId? VTClassId { get; set; }
  
  /// <summary>
  /// Clipboard Data.
  /// </summary>
  public DocumentModel.VariantTypes.VTClipboardData? VTClipboardData { get; set; }
  
}
