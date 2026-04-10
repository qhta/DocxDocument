namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a reference to printer settings in a Wordprocessing document.
/// This class is used to associate printer configuration data with a document section, enabling advanced printing options and section-specific printer settings.
/// </summary>
[OpenXmlType(typeof(DXW.PrinterSettingsReference))]
[XmlRoot("PrinterSettingsReference", Namespace = "DocumentModel.Wordprocessing")]
public class PrinterSettingsReference : RelationshipType<DXW.PrinterSettingsReference>, ISectionPropertiesContent
{
}