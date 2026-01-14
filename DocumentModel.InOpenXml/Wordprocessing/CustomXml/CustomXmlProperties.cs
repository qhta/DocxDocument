namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the set of properties applied to a parent custom XML element in a WordprocessingML document.
/// This interface extends <see cref="ElementCollection{CustomXmlAttribute}"/> and provides a property for placeholder text, enabling advanced schema-based processing, annotation, and user guidance for custom XML markup.
/// </summary>
public interface CustomXmlProperties: IElementCollection<CustomXmlAttribute>
{

  /// <summary>
  /// Placeholder text displayed in place of the custom XML element when its contents are empty (i.e., no runs of text within the element).
  /// </summary>
  public string? CustomXmlPlaceholder { get; set; }
}