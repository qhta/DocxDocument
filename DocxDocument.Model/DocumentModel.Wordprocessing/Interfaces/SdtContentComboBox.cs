namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentComboBox Class.
/// </summary>
public partial interface SdtContentComboBox
{
  /// <summary>
  /// Combo Box Last Saved Value
  /// </summary>
  public String? LastValue { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.ListItem>? ListItems { get; set; }
  
}
