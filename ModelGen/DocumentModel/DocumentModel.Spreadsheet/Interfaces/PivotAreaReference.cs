namespace DocumentModel.Spreadsheet;

/// <summary>
/// Reference.
/// </summary>
public interface PivotAreaReference // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Field Index
  /// </summary>
  public UInt32? Field { get ; set; }
  
  /// <summary>
  /// Item Index Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  /// <summary>
  /// Selected
  /// </summary>
  public Boolean? Selected { get ; set; }
  
  /// <summary>
  /// Positional Reference
  /// </summary>
  public Boolean? ByPosition { get ; set; }
  
  /// <summary>
  /// Relative Reference
  /// </summary>
  public Boolean? Relative { get ; set; }
  
  /// <summary>
  /// Include Default Filter
  /// </summary>
  public Boolean? DefaultSubtotal { get ; set; }
  
  /// <summary>
  /// Include Sum Filter
  /// </summary>
  public Boolean? SumSubtotal { get ; set; }
  
  /// <summary>
  /// Include CountA Filter
  /// </summary>
  public Boolean? CountASubtotal { get ; set; }
  
  /// <summary>
  /// Include Average Filter
  /// </summary>
  public Boolean? AverageSubtotal { get ; set; }
  
  /// <summary>
  /// Include Maximum Filter
  /// </summary>
  public Boolean? MaxSubtotal { get ; set; }
  
  /// <summary>
  /// Include Minimum Filter
  /// </summary>
  public Boolean? MinSubtotal { get ; set; }
  
  /// <summary>
  /// Include Product Filter
  /// </summary>
  public Boolean? ApplyProductInSubtotal { get ; set; }
  
  /// <summary>
  /// Include Count Subtotal
  /// </summary>
  public Boolean? CountSubtotal { get ; set; }
  
  /// <summary>
  /// Include StdDev Filter
  /// </summary>
  public Boolean? ApplyStandardDeviationInSubtotal { get ; set; }
  
  /// <summary>
  /// Include StdDevP Filter
  /// </summary>
  public Boolean? ApplyStandardDeviationPInSubtotal { get ; set; }
  
  /// <summary>
  /// Include Var Filter
  /// </summary>
  public Boolean? ApplyVarianceInSubtotal { get ; set; }
  
  /// <summary>
  /// Include VarP Filter
  /// </summary>
  public Boolean? ApplyVariancePInSubtotal { get ; set; }
  
  public Collection<UInt32>? FieldItems { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
