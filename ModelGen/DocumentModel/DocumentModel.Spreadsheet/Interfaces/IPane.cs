namespace DocumentModel.Spreadsheet;

/// <summary>
/// View Pane.
/// </summary>
public interface IPane // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Horizontal Split Position
  /// </summary>
  public Double? HorizontalSplit { get ; set; }
  
  /// <summary>
  /// Vertical Split Position
  /// </summary>
  public Double? VerticalSplit { get ; set; }
  
  /// <summary>
  /// Top Left Visible Cell
  /// </summary>
  public String? TopLeftCell { get ; set; }
  
  /// <summary>
  /// Active Pane
  /// </summary>
  public PaneKind? ActivePane { get ; set; }
  
  /// <summary>
  /// Split State
  /// </summary>
  public PaneStateKind? State { get ; set; }
  
}
