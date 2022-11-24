namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the PivotSource Class.
/// </summary>
public interface IPivotSource // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pivot Name.
  /// </summary>
  public IPivotTableName? PivotTableName { get ; set; }
  
  /// <summary>
  /// Format ID.
  /// </summary>
  public IFormatId? FormatId { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
