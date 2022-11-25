namespace DocumentModel.Spreadsheet;

/// <summary>
/// Break.
/// </summary>
public interface IBreak // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Id
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// Minimum
  /// </summary>
  public System.UInt32? Min { get ; set; }
  
  /// <summary>
  /// Maximum
  /// </summary>
  public System.UInt32? Max { get ; set; }
  
  /// <summary>
  /// Manual Page Break
  /// </summary>
  public System.Boolean? ManualPageBreak { get ; set; }
  
  /// <summary>
  /// Pivot-Created Page Break
  /// </summary>
  public System.Boolean? PivotTablePageBreak { get ; set; }
  
}
