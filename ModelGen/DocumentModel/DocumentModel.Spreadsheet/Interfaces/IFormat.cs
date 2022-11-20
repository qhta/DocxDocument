namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotTable Format.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotArea))]
public interface IFormat // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Format Action
  /// </summary>
  public FormatActionValues? Action { get ; set; }
  
  /// <summary>
  /// Format Id
  /// </summary>
  public uint? FormatId { get ; set; }
  
  /// <summary>
  /// Pivot Table Location.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotArea? PivotArea { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
