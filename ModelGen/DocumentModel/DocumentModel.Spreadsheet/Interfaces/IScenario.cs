namespace DocumentModel.Spreadsheet;

/// <summary>
/// Scenario.
/// </summary>
public interface IScenario // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Scenario Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Scenario Locked
  /// </summary>
  public System.Boolean? Locked { get ; set; }
  
  /// <summary>
  /// Hidden Scenario
  /// </summary>
  public System.Boolean? Hidden { get ; set; }
  
  /// <summary>
  /// Changing Cell Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  /// <summary>
  /// User Name
  /// </summary>
  public System.String? User { get ; set; }
  
  /// <summary>
  /// Scenario Comment
  /// </summary>
  public System.String? Comment { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IInputCells>? InputCellses { get ; set; }
  
}
