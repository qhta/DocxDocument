namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a single list item within the parent combo box structured document tag. Each list item shall be displayed in the list displayed for the nearest ancestor structured document tag (if a user interface is present).
/// </summary>
public partial class ListItem
{
  
  /// <summary>
  ///   List Entry Display Text
  /// </summary>
  public String? DisplayText { get; set; }
  
  
  /// <summary>
  ///   List Entry Value
  /// </summary>
  public String? Value { get; set; }
  
}
