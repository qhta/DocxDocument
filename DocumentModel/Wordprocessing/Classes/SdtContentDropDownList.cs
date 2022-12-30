namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDropDownList Class.
/// </summary>
public partial class SdtContentDropDownList
{
  /// <summary>
  /// Drop-down List Last Saved Value
  /// </summary>
  public String? LastValue { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.ListItem>? ListItems { get; set; }
  
}
