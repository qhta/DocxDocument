namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtContentComboBox Class.
/// </summary>
[XmlObject]
public class SdtContentComboBox
{
  /// <summary>
  ///   Combo Box Last Saved Value
  /// </summary>
  public String? LastValue { get; set; }

  public Collection<ListItem>? ListItems { get; set; }
}