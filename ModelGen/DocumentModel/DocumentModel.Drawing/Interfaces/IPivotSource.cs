namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PivotSource Class.
/// </summary>
public interface IPivotSource // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pivot Name.
  /// </summary>
  public System.String? PivotTableName { get ; set; }
  
  /// <summary>
  /// Format ID.
  /// </summary>
  public System.UInt32? FormatId { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
