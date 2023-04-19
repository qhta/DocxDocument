namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SdtContentComboBox Class.
/// </summary>
public class SdtContentComboBox: ModelElement
{
  /// <summary>
  ///   Combo Box Last Saved Value
  /// </summary>
  public string? LastValue { get; set; }

  public Collection<ListItem>? ListItems { get; set; }
}