namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SdtContentDropDownList Class.
/// </summary>
public class SdtContentDropDownList: ModelElement
{
  /// <summary>
  ///   Drop-down List Last Saved Value
  /// </summary>
  public string? LastValue { get; set; }

  public Collection<ListItem>? ListItems { get; set; }
}