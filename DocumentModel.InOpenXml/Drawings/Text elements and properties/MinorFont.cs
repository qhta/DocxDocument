namespace DocumentModel.Drawings;
/// <summary>
///   Represents the minor font settings for a font scheme, including definitions for Latin, East Asian, complex scripts, and supplemental fonts.
/// </summary>
[OpenXmlType(typeof(DXD.MinorFont))]
[XmlRoot("MinorFont", Namespace = "DocumentModel.Drawings")]
public class MinorFont : SchemeFont<DXD.MinorFont>
{
}