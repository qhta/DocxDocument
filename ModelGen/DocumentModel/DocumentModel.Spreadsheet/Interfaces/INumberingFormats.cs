namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the NumberingFormats Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.INumberingFormat))]
public interface INumberingFormats // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Number Format Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
