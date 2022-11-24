namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableIndentation Class.
/// </summary>
public interface ITableIndentation // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// w
  /// </summary>
  public Int32? Width { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public TableWidthUnitKind? Type { get ; set; }
  
}
