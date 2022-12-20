namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableLayout Class.
/// </summary>
public partial interface TableLayout
{
  /// <summary>
  /// Table Layout Setting
  /// </summary>
  public DocumentModel.Wordprocessing.TableLayoutKind? Type { get; set; }
  
}
