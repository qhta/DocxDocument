namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the PivotSource Class.
/// </summary>
public interface IPivotSource // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pivot Name.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? PivotTableName { get ; set; }
  
  /// <summary>
  /// Format ID.
  /// </summary>
  public System.UInt32? FormatId { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
