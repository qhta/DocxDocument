namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Consolidation References.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDataReference))]
public interface IDataReferences // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Data Consolidation Reference Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
