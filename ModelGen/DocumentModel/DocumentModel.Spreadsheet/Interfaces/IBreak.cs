namespace DocumentModel.Spreadsheet;

/// <summary>
/// Break.
/// </summary>
public interface IBreak // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Id
  /// </summary>
  public uint? Id { get ; set; }
  
  /// <summary>
  /// Minimum
  /// </summary>
  public uint? Min { get ; set; }
  
  /// <summary>
  /// Maximum
  /// </summary>
  public uint? Max { get ; set; }
  
  /// <summary>
  /// Manual Page Break
  /// </summary>
  public bool? ManualPageBreak { get ; set; }
  
  /// <summary>
  /// Pivot-Created Page Break
  /// </summary>
  public bool? PivotTablePageBreak { get ; set; }
  
}
