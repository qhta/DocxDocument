namespace DocumentModel.Spreadsheet;

/// <summary>
/// View Pane.
/// </summary>
public interface IPane // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Horizontal Split Position
  /// </summary>
  public double? HorizontalSplit { get ; set; }
  
  /// <summary>
  /// Vertical Split Position
  /// </summary>
  public double? VerticalSplit { get ; set; }
  
  /// <summary>
  /// Top Left Visible Cell
  /// </summary>
  public string? TopLeftCell { get ; set; }
  
  /// <summary>
  /// Active Pane
  /// </summary>
  public Pane? ActivePane { get ; set; }
  
  /// <summary>
  /// Split State
  /// </summary>
  public PaneState? State { get ; set; }
  
}
