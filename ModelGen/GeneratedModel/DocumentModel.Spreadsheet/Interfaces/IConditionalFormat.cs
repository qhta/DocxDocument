namespace DocumentModel.Spreadsheet;

/// <summary>
/// Conditional Formatting.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IPivotAreas))]
public interface IConditionalFormat // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Conditional Formatting Scope
  /// </summary>
  public Scope? Scope { get ; set; }
  
  /// <summary>
  /// Conditional Formatting Rule Type
  /// </summary>
  public DocumentModel.Spreadsheet.Rule? Type { get ; set; }
  
  /// <summary>
  /// Priority
  /// </summary>
  public uint? Priority { get ; set; }
  
  /// <summary>
  /// Pivot Areas.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotAreas? PivotAreas { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
