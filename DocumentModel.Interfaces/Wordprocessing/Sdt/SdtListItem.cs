namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a combo box list item in a structured document tag (SDT) in a Wordprocessing document.
/// This interface provides properties for the display text and value of the list item, enabling advanced customization and management of combo box options in SDTs.
/// </summary>
public interface SdtListItem : CollectionItem
{

  /// <summary>
  /// List entry display text, specifying the text shown to users in the combo box.
  /// </summary>
  public string? DisplayText { get; set; }

  /// <summary>
  /// List entry value, specifying the underlying value associated with the display text.
  /// </summary>
  public string? Value { get; set; }
}