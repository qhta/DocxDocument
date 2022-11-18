namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableLayout Class.
/// </summary>
public interface ITableLayout // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Table Layout Setting
  /// </summary>
  public TableLayout? Type { get ; set; }
  
}
