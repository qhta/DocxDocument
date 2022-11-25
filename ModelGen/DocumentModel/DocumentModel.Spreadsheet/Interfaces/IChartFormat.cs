namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotChart Format.
/// </summary>
public interface IChartFormat // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Chart Index
  /// </summary>
  public System.UInt32? Chart { get ; set; }
  
  /// <summary>
  /// Pivot Format Id
  /// </summary>
  public System.UInt32? Format { get ; set; }
  
  /// <summary>
  /// Series Format
  /// </summary>
  public System.Boolean? Series { get ; set; }
  
  /// <summary>
  /// Pivot Table Location Rule.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotArea? PivotArea { get ; set; }
  
}
