namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableLayout Class.
/// </summary>
public interface ITableLayout // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Table Layout Setting
  /// </summary>
  public TableLayoutKind? Type { get ; set; }
  
}
