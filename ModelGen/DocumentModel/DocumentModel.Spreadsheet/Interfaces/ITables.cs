namespace DocumentModel.Spreadsheet;

/// <summary>
/// Tables.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFieldItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMissingTable))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICharacterValue))]
public interface ITables // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Count of Tables
  /// </summary>
  public uint? Count { get ; set; }
  
}
