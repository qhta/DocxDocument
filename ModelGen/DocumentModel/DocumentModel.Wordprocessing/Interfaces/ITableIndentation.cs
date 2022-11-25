namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableIndentation Class.
/// </summary>
public interface ITableIndentation // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// w
  /// </summary>
  public System.Int32? Width { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthUnitKind? Type { get ; set; }
  
}
