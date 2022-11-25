namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotTable Format.
/// </summary>
public interface IFormat // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Format Action
  /// </summary>
  public DocumentModel.Spreadsheet.FormatActionKind? Action { get ; set; }
  
  /// <summary>
  /// Format Id
  /// </summary>
  public System.UInt32? FormatId { get ; set; }
  
  /// <summary>
  /// Pivot Table Location.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotArea? PivotArea { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
