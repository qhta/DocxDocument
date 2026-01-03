namespace DocumentModel.Wordprocessing;
/// <summary>
///   Base interface for current table properties
/// </summary>
public interface CurrentTableProperties: BaseTableProperties
{
  /// <summary>
  ///   Preferred Table Width.
  /// </summary>
  public TableWidth? TableWidth { get; set; }
  /// <summary>
  ///   Table Layout.
  /// </summary>
  public TableLayoutKind? TableLayout { get; set; }
  /// <summary>
  ///   Table Style Conditional Formatting Settings.
  /// </summary>
  public TableLookFlags? TableLook { get; set; }
}