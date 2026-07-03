namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of endnote separator references in a WordprocessingML document.
/// This class provides access to and management of <see cref = "EndnoteSeparator"/> objects, enabling advanced organization and referencing of endnote separators for visual separation and formatting of endnote content.
/// </summary>
[OpenXmlType(typeof(DXW.EndnoteSpecialReference))]
[DataContract]
[XmlRoot("EndnoteSeparators", Namespace = "DocumentModel.Wordprocessing")]
public class EndnoteSeparators : 
  ModelElementCollection<EndnoteSeparator, DXW.EndnoteDocumentWideProperties, DXW.EndnoteSpecialReference>, 
  ILimitedCollection
{
  /// <summary>
  /// Default constructor for the <see cref = "EndnoteSeparators"/> class, initializing a new instance of the collection without a parent element.
  /// </summary>
  public EndnoteSeparators() : base()
  {
  }

  /// <summary>
  /// Initializes a new instance of the EndnoteSeparators class using the specified endnote document-wide properties as
  /// the parent. 
  /// </summary>
  /// <param name="parent">The parent EndnoteDocumentWideProperties object that provides the context and updatable element for this instance.
  /// Cannot be null.</param>
  public EndnoteSeparators(DMW.EndnoteDocumentWideProperties parent): base(parent, parent.GetUpdatableElement() as DXW.EndnoteDocumentWideProperties)
  {

  }

  /// <summary>
  /// Gets the maximum number of footnote separators allowed in the collection, which is 3.
  /// </summary>
  public int MaxCount => 3;

}