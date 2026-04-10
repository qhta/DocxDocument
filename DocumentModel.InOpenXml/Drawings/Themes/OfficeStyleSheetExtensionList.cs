namespace DocumentModel.Drawings;
/// <summary>
///   Represents a collection of office style sheet extensions for additional or future extensibility.
/// </summary>
[OpenXmlType(typeof(OfficeStyleSheetExtension))]
[XmlRoot("OfficeStyleSheetExtensionList", Namespace = "DocumentModel.Drawings")]
public class OfficeStyleSheetExtensionList : ModelElementCollection<OfficeStyleSheetExtension, DXD.OfficeStyleSheetExtensionList, DXD.OfficeStyleSheetExtension>
{
}