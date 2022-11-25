namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableWidthType Class.
/// </summary>
public interface ITableWidthType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Table Width Value
  /// </summary>
  public System.String? Width { get ; set; }
  
  /// <summary>
  /// Table Width Type
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthUnitKind? Type { get ; set; }
  
}
