namespace DocumentModel.Wordprocessing;

/// <summary>
/// Combo Box List Item.
/// </summary>
public interface ListItem // : System.Boolean
{
  /// <summary>
  /// List Entry Display Text
  /// </summary>
  public String? DisplayText { get ; set; }
  
  /// <summary>
  /// List Entry Value
  /// </summary>
  public String? Value { get ; set; }
  
}
