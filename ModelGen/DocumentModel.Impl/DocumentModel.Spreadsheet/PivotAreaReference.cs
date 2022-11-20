namespace DocumentModel.Spreadsheet;

/// <summary>
/// Reference.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IFieldItem))]
public class PivotAreaReference: IPivotAreaReference
{
  /// <summary>
  /// Field Index
  /// </summary>
  public uint? Field
  {
    get;
    set;
  }
  
  /// <summary>
  /// Item Index Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
  /// <summary>
  /// Selected
  /// </summary>
  public bool? Selected
  {
    get;
    set;
  }
  
  /// <summary>
  /// Positional Reference
  /// </summary>
  public bool? ByPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// Relative Reference
  /// </summary>
  public bool? Relative
  {
    get;
    set;
  }
  
  /// <summary>
  /// Include Default Filter
  /// </summary>
  public bool? DefaultSubtotal
  {
    get;
    set;
  }
  
  /// <summary>
  /// Include Sum Filter
  /// </summary>
  public bool? SumSubtotal
  {
    get;
    set;
  }
  
  /// <summary>
  /// Include CountA Filter
  /// </summary>
  public bool? CountASubtotal
  {
    get;
    set;
  }
  
  /// <summary>
  /// Include Average Filter
  /// </summary>
  public bool? AverageSubtotal
  {
    get;
    set;
  }
  
  /// <summary>
  /// Include Maximum Filter
  /// </summary>
  public bool? MaxSubtotal
  {
    get;
    set;
  }
  
  /// <summary>
  /// Include Minimum Filter
  /// </summary>
  public bool? MinSubtotal
  {
    get;
    set;
  }
  
  /// <summary>
  /// Include Product Filter
  /// </summary>
  public bool? ApplyProductInSubtotal
  {
    get;
    set;
  }
  
  /// <summary>
  /// Include Count Subtotal
  /// </summary>
  public bool? CountSubtotal
  {
    get;
    set;
  }
  
  /// <summary>
  /// Include StdDev Filter
  /// </summary>
  public bool? ApplyStandardDeviationInSubtotal
  {
    get;
    set;
  }
  
  /// <summary>
  /// Include StdDevP Filter
  /// </summary>
  public bool? ApplyStandardDeviationPInSubtotal
  {
    get;
    set;
  }
  
  /// <summary>
  /// Include Var Filter
  /// </summary>
  public bool? ApplyVarianceInSubtotal
  {
    get;
    set;
  }
  
  /// <summary>
  /// Include VarP Filter
  /// </summary>
  public bool? ApplyVariancePInSubtotal
  {
    get;
    set;
  }
  
}
