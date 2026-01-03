namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtContentDropDownList Class.
/// </summary>
public interface SdtContentDropDownList: IModelElement
{
  /// <summary>
  ///   Drop-down List Last Saved Value
  /// </summary>
  public string? LastValue { get; set; }
  public Collection<ListItem>? ListItems { get; set; }
}