namespace DocumentModel.Wordprocessing;

/// <summary>
///   Base class Ifor current table properties
/// </summary>
public abstract class CurrentTableProperties: BaseTableProperties
{
  /// <summary>
  ///   Preferred ITable Width.
  /// </summary>
  public TableWidth? TableWidth { get; set; }

  /// <summary>
  ///   ITable Layout.
  /// </summary>
  public TableLayoutKind? TableLayout { get; set; }

  /// <summary>
  ///   ITable IStyle Conditional Formatting Settings.
  /// </summary>
  public TableLookFlags? TableLook { get; set; }
}
