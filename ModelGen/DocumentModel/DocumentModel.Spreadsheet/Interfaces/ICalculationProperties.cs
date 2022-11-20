namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculationProperties Class.
/// </summary>
public interface ICalculationProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Calculation Id
  /// </summary>
  public uint? CalculationId { get ; set; }
  
  /// <summary>
  /// Calculation Mode
  /// </summary>
  public CalculateModeValues? CalculationMode { get ; set; }
  
  /// <summary>
  /// Full Calculation On Load
  /// </summary>
  public bool? FullCalculationOnLoad { get ; set; }
  
  /// <summary>
  /// Reference Mode
  /// </summary>
  public ReferenceModeValues? ReferenceMode { get ; set; }
  
  /// <summary>
  /// Calculation Iteration
  /// </summary>
  public bool? Iterate { get ; set; }
  
  /// <summary>
  /// Iteration Count
  /// </summary>
  public uint? IterateCount { get ; set; }
  
  /// <summary>
  /// Iterative Calculation Delta
  /// </summary>
  public double? IterateDelta { get ; set; }
  
  /// <summary>
  /// Full Precision Calculation
  /// </summary>
  public bool? FullPrecision { get ; set; }
  
  /// <summary>
  /// Calc Completed
  /// </summary>
  public bool? CalculationCompleted { get ; set; }
  
  /// <summary>
  /// Calculate On Save
  /// </summary>
  public bool? CalculationOnSave { get ; set; }
  
  /// <summary>
  /// Concurrent Calculations
  /// </summary>
  public bool? ConcurrentCalculation { get ; set; }
  
  /// <summary>
  /// Concurrent Thread Manual Count
  /// </summary>
  public uint? ConcurrentManualCount { get ; set; }
  
  /// <summary>
  /// Force Full Calculation
  /// </summary>
  public bool? ForceFullCalculation { get ; set; }
  
}
