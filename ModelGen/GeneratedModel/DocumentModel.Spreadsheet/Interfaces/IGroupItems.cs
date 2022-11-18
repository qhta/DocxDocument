namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Group Items.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IBooleanItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDateTimeItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IErrorItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMissingItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.INumberItem))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IStringItem))]
public interface IGroupItems // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Items Created Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
