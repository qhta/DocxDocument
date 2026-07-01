namespace DocumentModel.Drawings;
/// <summary>
///   Represents the major font settings for a font scheme, including definitions for Latin, East Asian, complex scripts, and supplemental fonts.
/// </summary>
[OpenXmlType(typeof(DXD.MajorFont))]
[DataContract]
[XmlRoot("MajorFont", Namespace = "DocumentModel.Drawings")]
public class MajorFont : SchemeFont<DXD.MajorFont>
{
}