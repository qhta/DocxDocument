namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtContentDropDownList Class.
/// </summary>
public class SdtContentDropDownList: ModelElement
{
  /// <summary>
  ///   Drop-down List Last Saved Value
  /// </summary>
  public String? LastValue { get; set; }

  public Collection<ListItem>? ListItems { get; set; }
}