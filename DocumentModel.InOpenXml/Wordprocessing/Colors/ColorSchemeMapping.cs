namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specific DXW.ColorSchemeMapping mapping class.
/// </summary>
[OpenXmlType(typeof(DXW.ColorSchemeMapping))]
[DataContract]
[XmlRoot("ColorSchemeMapping", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class ColorSchemeMapping : DMD.ColorMap<DXW.ColorSchemeMapping>
{
}