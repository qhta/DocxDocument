namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtContentDropDownList Class.
/// </summary>
public interface SdtContentDropDownList
{
  /// <summary>
  ///   Drop-down List Last Saved Value
  /// </summary>
  public string? LastValue { get; set; }
  public ListItems ListItems { get; set; }
}

public interface ListItems : ElementCollection<ListItem>
{
}