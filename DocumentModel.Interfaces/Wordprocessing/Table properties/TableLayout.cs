namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the table layout settings for a table in a Wordprocessing document.
/// This interface provides a property for specifying the layout type, enabling control over table rendering and structure (such as fixed or auto layout).
/// </summary>
public interface TableLayout
{
  /// <summary>
  /// Table layout setting, specifying the type of layout algorithm used for the table.
  /// </summary>
  public TableLayoutKind? Type { get; set; }
}