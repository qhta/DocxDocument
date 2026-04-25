namespace DocumentModel.Drawings;
/// <summary>
///   Represents a collection of supplemental fonts for additional language and script support in a font scheme.
/// </summary>
[OpenXmlType(typeof(DXD.FontCollectionType))]
[XmlRoot("SupplementalFonts", Namespace = "DocumentModel.Drawings")]
public class SupplementalFonts : ModelElementCollection<SupplementalFont, DXD.FontCollectionType, DXD.SupplementalFont>
{

}