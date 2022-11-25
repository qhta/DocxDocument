namespace DocumentModel.Spreadsheet;

/// <summary>
/// Reference.
/// </summary>
public interface IPivotAreaReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Index
  /// </summary>
  public System.UInt32? Field { get ; set; }
  
  /// <summary>
  /// Item Index Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  /// <summary>
  /// Selected
  /// </summary>
  public System.Boolean? Selected { get ; set; }
  
  /// <summary>
  /// Positional Reference
  /// </summary>
  public System.Boolean? ByPosition { get ; set; }
  
  /// <summary>
  /// Relative Reference
  /// </summary>
  public System.Boolean? Relative { get ; set; }
  
  /// <summary>
  /// Include Default Filter
  /// </summary>
  public System.Boolean? DefaultSubtotal { get ; set; }
  
  /// <summary>
  /// Include Sum Filter
  /// </summary>
  public System.Boolean? SumSubtotal { get ; set; }
  
  /// <summary>
  /// Include CountA Filter
  /// </summary>
  public System.Boolean? CountASubtotal { get ; set; }
  
  /// <summary>
  /// Include Average Filter
  /// </summary>
  public System.Boolean? AverageSubtotal { get ; set; }
  
  /// <summary>
  /// Include Maximum Filter
  /// </summary>
  public System.Boolean? MaxSubtotal { get ; set; }
  
  /// <summary>
  /// Include Minimum Filter
  /// </summary>
  public System.Boolean? MinSubtotal { get ; set; }
  
  /// <summary>
  /// Include Product Filter
  /// </summary>
  public System.Boolean? ApplyProductInSubtotal { get ; set; }
  
  /// <summary>
  /// Include Count Subtotal
  /// </summary>
  public System.Boolean? CountSubtotal { get ; set; }
  
  /// <summary>
  /// Include StdDev Filter
  /// </summary>
  public System.Boolean? ApplyStandardDeviationInSubtotal { get ; set; }
  
  /// <summary>
  /// Include StdDevP Filter
  /// </summary>
  public System.Boolean? ApplyStandardDeviationPInSubtotal { get ; set; }
  
  /// <summary>
  /// Include Var Filter
  /// </summary>
  public System.Boolean? ApplyVarianceInSubtotal { get ; set; }
  
  /// <summary>
  /// Include VarP Filter
  /// </summary>
  public System.Boolean? ApplyVariancePInSubtotal { get ; set; }
  
}
