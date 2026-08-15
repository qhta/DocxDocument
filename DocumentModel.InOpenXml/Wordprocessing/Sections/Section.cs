namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a section in a Word document.
/// </summary>
[DataContract]
[XmlRoot("Section", Namespace = "DocumentModel.Wordprocessing")]
public class Section: ModelElement
{

  /// <summary>
  /// Initializes a new instance of the Section class.
  /// </summary>
  public Section(): base() { }

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

  /// <summary>
  /// Paragraph that contains the section properties, if applicable.
  /// The last Section in a Story is not contained in a Paragraph, so this property will be null for the last Section in a Story.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public Paragraph? Paragraph => (SectionProperties?.Parent as ParagraphProperties)?.Parent as Paragraph;

  /// <summary>
  /// Parent items collections get from the parent Sections collection.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public ContentItemsCollection? ParentItemsCollection => (Parent as Sections)?.ParentItemsCollection;

  /// <summary>
  /// Gets the range of the section, which includes the start and end positions of the section within the document.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public Range Range => GetRange();


  /// <summary>
  /// Gets the range of the section, which includes the start and end positions of the section within the document.
  /// </summary>
  /// <returns></returns>
  public Range GetRange()
  {
    if (this.Collection is ICollection<Section> sectionCollection)
    {
      var sectionArray = sectionCollection.ToArray();
      var sectionIndex = Array.IndexOf(sectionArray, this);
      if (sectionIndex < 0)
        throw new InvalidOperationException("Section index not found.");
      ModelElement? sectionStart = null;
      if (sectionIndex == 0)
        sectionStart = (Parent as Sections)?.ParentItemsCollection?.FirstOrDefault();
      else
      {
        sectionStart = sectionArray[sectionIndex - 1].Paragraph?.Next;
      }
      if (sectionStart is null)
        throw new InvalidOperationException("Section start not found.");

      var sectionEnd = (Paragraph as ModelElement) ?? this;
      var range = new Range(this, sectionStart, sectionEnd);
      return range;
    }
    else
    {
      throw new InvalidOperationException("Section is not part of a section collection.");
    } 
  }

}