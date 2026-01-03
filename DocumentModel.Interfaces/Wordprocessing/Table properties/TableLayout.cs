namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableLayout Class.
/// </summary>
public interface TableLayout: IModelElement
{
  /// <summary>
  ///   Table Layout Setting
  /// </summary>
  public TableLayoutKind? Type { get; set; }
}