namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a section in a Word document.
/// </summary>
[DataContract]
[XmlRoot("Section", Namespace = "DocumentModel.Wordprocessing")]
public class Section : ModelElement
{

  /// <summary>
  /// Initializes a new instance of the Section class.
  /// </summary>
  public Section() : base() { }

  /// <summary>
  /// Initializes a new instance of the Section class with the specified parent element and section properties.
  /// </summary>
  /// <param name="parent">The parent element that will contain this Section instance. It can be ParagraphProperties or AbstractBody</param>
  /// <param name="sectionProperties">The properties of the section, such as page size, margins, and other layout settings.</param>
  public Section(ModelElement parent, SectionProperties? sectionProperties): base(parent)
  {
    SectionProperties = sectionProperties;
  }

  /// <summary>
  /// Specifies the properties of the section, such as page size, margins, and other layout settings.
  /// </summary>
  public SectionProperties? SectionProperties { get; set; }


}