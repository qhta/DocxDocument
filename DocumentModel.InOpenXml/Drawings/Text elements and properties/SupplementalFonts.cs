namespace DocumentModel.Drawings;
/// <summary>
///   Represents a collection of supplemental fonts for additional language and script support in a font scheme.
/// </summary>
[OpenXmlType(typeof(DXD.FontCollectionType))]
[XmlRoot("SupplementalFonts", Namespace = "DocumentModel.Drawings")]
public class SupplementalFonts : ModelElementCollection<SupplementalFont, DXD.FontCollectionType, DXD.SupplementalFont>
{
  /// <summary>
  /// Default constructor for the SupplementalFonts class, initializing a new instance of the SupplementalFonts class.
  /// </summary>
  public SupplementalFonts() : base() { }

  /// <summary>
  /// Initializes a new instance of the SupplementalFonts class with the specified parent element.
  /// </summary>
  /// <param name="parent">The parent ModelElement that owns this SupplementalFonts instance. Cannot be null.</param>
  /// <param name="openXmlCollection">The OpenXml collection of supplemental fonts.</param>
  public SupplementalFonts(ModelElement parent, DXD.FontCollectionType? openXmlCollection) : base(parent, openXmlCollection) { }


}