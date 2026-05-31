namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of footnote separator references in a WordprocessingML document.
/// This class provides access to and management of <see cref = "FootnoteSeparator"/> objects, enabling advanced organization and referencing of footnote separators for visual separation and formatting of footnote content.
/// </summary>
[OpenXmlType(typeof(DXW.FootnoteSpecialReference))]
[XmlRoot("FootnoteSeparators", Namespace = "DocumentModel.Wordprocessing")]
public class FootnoteSeparators : ModelElementCollection<FootnoteSeparator, DXW.FootnoteDocumentWideProperties, DXW.FootnoteSpecialReference>
{
  /// <summary>
  /// Default constructor for the <see cref = "FootnoteSeparators"/> class, initializing a new instance of the collection without a parent element.
  /// </summary>
  public FootnoteSeparators() : base()
  {
  }

  /// <summary>
  /// Initializes a new instance of the FootnoteSeparators class using the specified Footnote document-wide properties as
  /// the parent. 
  /// </summary>
  /// <param name="parent">The parent FootnoteDocumentWideProperties object that provides the context and updatable element for this instance.
  /// Cannot be null.</param>
  public FootnoteSeparators(DMW.FootnoteDocumentWideProperties parent) : base(parent, parent.GetUpdatableElement() as DXW.FootnoteDocumentWideProperties)
  {

  }
}