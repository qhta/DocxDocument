namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a combo box list item in a structured document tag (SDT) in a Wordprocessing document.
/// This class provides properties for the display text and value of the list item, enabling advanced customization and management of combo box options in SDTs.
/// </summary>
[DataContract]
[XmlRoot("SdtListItem", Namespace = "DocumentModel.Wordprocessing")]
public partial class SdtListItem : ModelElement
{
 /// <summary>
 /// List entry display text, specifying the text shown to users in the combo box.
 /// </summary>
 public string? DisplayText { get => _DisplayText; set => UpdateField(ref _DisplayText, value, nameof(DisplayText)); }
 private string? _DisplayText;

 /// <summary>
 /// List entry value, specifying the underlying value associated with the display text.
 /// </summary>
 public string? Value { get => _Value; set => UpdateField(ref _Value, value, nameof(Value)); }
 private string? _Value;
}