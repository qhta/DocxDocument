namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the SdtContentDropDownList Class.
/// </summary>
public class SdtContentDropDownList: ModelElement
{
  /// <summary>
  ///   Drop-down IList Last Saved Value
  /// </summary>
  public string? LastValue { get; set; }

  public Collection<ListItem>? ListItems { get; set; }
}
