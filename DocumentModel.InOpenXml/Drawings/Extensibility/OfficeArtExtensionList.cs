namespace DocumentModel;
/// <summary>
/// Represents a collection of DrawingML-specific extensions that enable future compatibility and enhanced
/// visual features for graphics, charts, diagrams, and other drawing objects in Office Open XML documents.
/// This specialized extension list focuses on extending Office Art (DrawingML) capabilities while maintaining
/// backward compatibility with older Office versions.
/// </summary>
[OpenXmlType(typeof(OfficeArtExtension))]
public class OfficeArtExtensionList : ModelElementCollection<OfficeArtExtension, DXOD.OfficeArtExtensionList, DXD.Extension>
{
}