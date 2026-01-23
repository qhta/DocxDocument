namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the configuration for a combo box content control in a structured document tag (SDT) in a Wordprocessing document.
/// This class provides properties for the last saved value and the list of items, enabling advanced customization and management of combo box options in SDTs.
/// </summary>
public partial class SdtContentComboBox : SdtListItems
{
  /// <summary>
  /// Combo box last saved value, specifying the most recently selected or entered option.
  /// </summary>
  public string? LastValue { get; set; }
}