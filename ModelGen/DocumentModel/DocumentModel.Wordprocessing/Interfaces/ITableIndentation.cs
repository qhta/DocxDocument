namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableIndentation Class.
/// </summary>
public interface ITableIndentation // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// w
  /// </summary>
  public int? Width { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public TableWidthUnitValues? Type { get ; set; }
  
}
