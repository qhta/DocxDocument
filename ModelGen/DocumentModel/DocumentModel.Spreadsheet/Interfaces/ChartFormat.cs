namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotChart Format.
/// </summary>
public interface ChartFormat // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Chart Index
  /// </summary>
  public UInt32? Chart { get ; set; }
  
  /// <summary>
  /// Pivot Format Id
  /// </summary>
  public UInt32? Format { get ; set; }
  
  /// <summary>
  /// Series Format
  /// </summary>
  public Boolean? Series { get ; set; }
  
  /// <summary>
  /// Pivot Table Location Rule.
  /// </summary>
  public PivotArea? PivotArea { get ; set; }
  
}
