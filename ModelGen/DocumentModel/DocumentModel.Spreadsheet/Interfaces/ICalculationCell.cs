namespace DocumentModel.Spreadsheet;

/// <summary>
/// Cell.
/// </summary>
public interface ICalculationCell // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Cell Reference
  /// </summary>
  public string? CellReference { get ; set; }
  
  /// <summary>
  /// Sheet Id
  /// </summary>
  public int? SheetId { get ; set; }
  
  /// <summary>
  /// Child Chain
  /// </summary>
  public bool? InChildChain { get ; set; }
  
  /// <summary>
  /// New Dependency Level
  /// </summary>
  public bool? NewLevel { get ; set; }
  
  /// <summary>
  /// New Thread
  /// </summary>
  public bool? NewThread { get ; set; }
  
  /// <summary>
  /// Array
  /// </summary>
  public bool? Array { get ; set; }
  
}
