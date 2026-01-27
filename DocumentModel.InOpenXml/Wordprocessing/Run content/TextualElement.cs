namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a textual element within a text run in WordprocessingML documents.
/// This class is used for inline text content, such as <see cref = "Text"/> and <see cref = "FieldCode"/>, and provides properties for the text value and deletion status.
/// </summary>
[OpenXmlType(typeof(T))]
public abstract partial class TextualElement<T> : ModelElement<T>, IRunContent where T : DX.OpenXmlElement
{
 /// <summary>
 /// Indicates whether this textual element is deleted.
 /// </summary>
 [DefaultValue(false)]
 public bool IsDeleted { get => _IsDeleted; set => UpdateField(ref _IsDeleted, value, nameof(IsDeleted)); }

 private bool _IsDeleted;
 /// <summary>
 /// The text value represented by this element.
 /// </summary>
 [XmlText]
 public string? Text { get => _Text; set => UpdateField(ref _Text, value, nameof(Text)); }

 private string? _Text;
}