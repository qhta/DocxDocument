namespace DocumentModel.Spreadsheet;

/// <summary>
/// Scenario.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IInputCells))]
public interface IScenario // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Scenario Name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Scenario Locked
  /// </summary>
  public bool? Locked { get ; set; }
  
  /// <summary>
  /// Hidden Scenario
  /// </summary>
  public bool? Hidden { get ; set; }
  
  /// <summary>
  /// Changing Cell Count
  /// </summary>
  public uint? Count { get ; set; }
  
  /// <summary>
  /// User Name
  /// </summary>
  public string? User { get ; set; }
  
  /// <summary>
  /// Scenario Comment
  /// </summary>
  public string? Comment { get ; set; }
  
}
