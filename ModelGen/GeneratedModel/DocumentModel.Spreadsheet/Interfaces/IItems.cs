namespace DocumentModel.Spreadsheet;

/// <summary>
/// Field Items.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IItem))]
public interface IItems // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
