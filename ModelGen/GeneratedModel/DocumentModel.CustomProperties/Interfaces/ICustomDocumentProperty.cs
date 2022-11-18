namespace DocumentModel.CustomProperties;

/// <summary>
/// Custom File Property.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTArray))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTClipboardData))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTEmpty))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTNull))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTVector))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTVStreamData))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTClassId))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTCurrency))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTError))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTBlob))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTOBlob))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTStreamData))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTOStreamData))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTStorage))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTOStorage))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTBool))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTByte))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTDate))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTFileTime))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTDecimal))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTDouble))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTFloat))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTInt32))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTInteger))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTInt64))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTShort))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTLPSTR))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTLPWSTR))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTBString))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTUnsignedByte))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTUnsignedInt32))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTUnsignedInteger))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTUnsignedInt64))]
[ChildElementInfo(typeof(DocumentModel.VariantTypes.IVTUnsignedShort))]
public interface ICustomDocumentProperty // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Format ID
  /// </summary>
  public string? FormatId { get ; set; }
  
  /// <summary>
  /// Property ID
  /// </summary>
  public int? PropertyId { get ; set; }
  
  /// <summary>
  /// Custom File Property Name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Bookmark Link Target
  /// </summary>
  public string? LinkTarget { get ; set; }
  
  /// <summary>
  /// Vector.
  /// </summary>
  public IVTVector? VTVector { get ; set; }
  
  /// <summary>
  /// Array.
  /// </summary>
  public IVTArray? VTArray { get ; set; }
  
  /// <summary>
  /// Binary Blob.
  /// </summary>
  public IVTBlob? VTBlob { get ; set; }
  
  /// <summary>
  /// Binary Blob Object.
  /// </summary>
  public IVTOBlob? VTOBlob { get ; set; }
  
  /// <summary>
  /// Empty.
  /// </summary>
  public IVTEmpty? VTEmpty { get ; set; }
  
  /// <summary>
  /// Null.
  /// </summary>
  public IVTNull? VTNull { get ; set; }
  
  /// <summary>
  /// 1-Byte Signed Integer.
  /// </summary>
  public IVTByte? VTByte { get ; set; }
  
  /// <summary>
  /// 2-Byte Signed Integer.
  /// </summary>
  public IVTShort? VTShort { get ; set; }
  
  /// <summary>
  /// 4-Byte Signed Integer.
  /// </summary>
  public IVTInt32? VTInt32 { get ; set; }
  
  /// <summary>
  /// 8-Byte Signed Integer.
  /// </summary>
  public IVTInt64? VTInt64 { get ; set; }
  
  /// <summary>
  /// Integer.
  /// </summary>
  public IVTInteger? VTInteger { get ; set; }
  
  /// <summary>
  /// 1-Byte Unsigned Integer.
  /// </summary>
  public IVTUnsignedByte? VTUnsignedByte { get ; set; }
  
  /// <summary>
  /// 2-Byte Unsigned Integer.
  /// </summary>
  public IVTUnsignedShort? VTUnsignedShort { get ; set; }
  
  /// <summary>
  /// 4-Byte Unsigned Integer.
  /// </summary>
  public IVTUnsignedInt32? VTUnsignedInt32 { get ; set; }
  
  /// <summary>
  /// 8-Byte Unsigned Integer.
  /// </summary>
  public IVTUnsignedInt64? VTUnsignedInt64 { get ; set; }
  
  /// <summary>
  /// Unsigned Integer.
  /// </summary>
  public IVTUnsignedInteger? VTUnsignedInteger { get ; set; }
  
  /// <summary>
  /// 4-Byte Real Number.
  /// </summary>
  public IVTFloat? VTFloat { get ; set; }
  
  /// <summary>
  /// 8-Byte Real Number.
  /// </summary>
  public IVTDouble? VTDouble { get ; set; }
  
  /// <summary>
  /// Decimal.
  /// </summary>
  public IVTDecimal? VTDecimal { get ; set; }
  
  /// <summary>
  /// LPSTR.
  /// </summary>
  public IVTLPSTR? VTLPSTR { get ; set; }
  
  /// <summary>
  /// LPWSTR.
  /// </summary>
  public IVTLPWSTR? VTLPWSTR { get ; set; }
  
  /// <summary>
  /// Basic String.
  /// </summary>
  public IVTBString? VTBString { get ; set; }
  
  /// <summary>
  /// Date and Time.
  /// </summary>
  public IVTDate? VTDate { get ; set; }
  
  /// <summary>
  /// File Time.
  /// </summary>
  public IVTFileTime? VTFileTime { get ; set; }
  
  /// <summary>
  /// Boolean.
  /// </summary>
  public IVTBool? VTBool { get ; set; }
  
  /// <summary>
  /// Currency.
  /// </summary>
  public IVTCurrency? VTCurrency { get ; set; }
  
  /// <summary>
  /// Error Status Code.
  /// </summary>
  public IVTError? VTError { get ; set; }
  
  /// <summary>
  /// Binary Stream.
  /// </summary>
  public IVTStreamData? VTStreamData { get ; set; }
  
  /// <summary>
  /// Binary Stream Object.
  /// </summary>
  public IVTOStreamData? VTOStreamData { get ; set; }
  
  /// <summary>
  /// Binary Storage.
  /// </summary>
  public IVTStorage? VTStorage { get ; set; }
  
  /// <summary>
  /// Binary Storage Object.
  /// </summary>
  public IVTOStorage? VTOStorage { get ; set; }
  
  /// <summary>
  /// Binary Versioned Stream.
  /// </summary>
  public IVTVStreamData? VTVStreamData { get ; set; }
  
  /// <summary>
  /// Class ID.
  /// </summary>
  public IVTClassId? VTClassId { get ; set; }
  
  /// <summary>
  /// Clipboard Data.
  /// </summary>
  public IVTClipboardData? VTClipboardData { get ; set; }
  
}
