namespace DocumentModel.Spreadsheet;

/// <summary>
/// Scenario.
/// </summary>
public interface IScenario // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Scenario Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Scenario Locked
  /// </summary>
  public Boolean? Locked { get ; set; }
  
  /// <summary>
  /// Hidden Scenario
  /// </summary>
  public Boolean? Hidden { get ; set; }
  
  /// <summary>
  /// Changing Cell Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  /// <summary>
  /// User Name
  /// </summary>
  public String? User { get ; set; }
  
  /// <summary>
  /// Scenario Comment
  /// </summary>
  public String? Comment { get ; set; }
  
  public Collection<IInputCells>? InputCellses { get ; set; }
  
}
