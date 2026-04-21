namespace DocumentModel.Drawings;
/// <summary>
///   Represents a collection of supplemental fonts for additional language and script support in a font scheme.
/// </summary>
[OpenXmlType(typeof(DXD.FontCollectionType))]
[XmlRoot("SupplementalFonts", Namespace = "DocumentModel.Drawings")]
public class SupplementalFonts : ModelElementCollection<SupplementalFont, DXD.FontCollectionType, DXD.SupplementalFont>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public SupplementalFonts() : base() { }

  /// <summary>
  /// Initializes a new instance of the class with the specified parent element.
  /// </summary>
  /// <param name="parent">The parent element of this collection.</param>
  public SupplementalFonts(ModelElement parent) : base(parent) { }
}