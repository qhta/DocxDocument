namespace DocumentModel.Wordprocessing;

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