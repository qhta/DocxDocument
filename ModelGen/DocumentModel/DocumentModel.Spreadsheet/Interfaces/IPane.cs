namespace DocumentModel.Spreadsheet;

/// <summary>
/// View Pane.
/// </summary>
public interface IPane // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Horizontal Split Position
  /// </summary>
  public System.Double? HorizontalSplit { get ; set; }
  
  /// <summary>
  /// Vertical Split Position
  /// </summary>
  public System.Double? VerticalSplit { get ; set; }
  
  /// <summary>
  /// Top Left Visible Cell
  /// </summary>
  public System.String? TopLeftCell { get ; set; }
  
  /// <summary>
  /// Active Pane
  /// </summary>
  public DocumentModel.Spreadsheet.PaneKind? ActivePane { get ; set; }
  
  /// <summary>
  /// Split State
  /// </summary>
  public DocumentModel.Spreadsheet.PaneStateKind? State { get ; set; }
  
}
