namespace DocumentModel.Spreadsheet;

/// <summary>
/// Break.
/// </summary>
public interface IBreak // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Id
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// Minimum
  /// </summary>
  public UInt32? Min { get ; set; }
  
  /// <summary>
  /// Maximum
  /// </summary>
  public UInt32? Max { get ; set; }
  
  /// <summary>
  /// Manual Page Break
  /// </summary>
  public Boolean? ManualPageBreak { get ; set; }
  
  /// <summary>
  /// Pivot-Created Page Break
  /// </summary>
  public Boolean? PivotTablePageBreak { get ; set; }
  
}
