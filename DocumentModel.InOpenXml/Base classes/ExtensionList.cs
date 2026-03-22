namespace DocumentModel;
/// <summary>
/// Represents a collection of extensions specific to elements that enable future compatibility, enhanced visual features, and custom functionality for graphics, shapes, charts, and diagrams in Office Open XML documents.
/// </summary>
/// <remarks>
/// <para>
/// <see cref="IExtensionList"/> in the <see cref="DocumentModel.Drawings"/> namespace is the general-purpose extension mechanism for DrawingML (Office Art) elements. While specialized extension lists exist for specific scenarios (like <see cref="BlipExtensionList"/> for images or <see cref="ConnectorLockingExtensionList"/>
/// for connectors), this ExtensionList handles general DrawingML extensions that don't fit specialized categories.
/// </para>
/// <para>
/// This DrawingML ExtensionList differs from other extension mechanisms:
/// <list type="bullet">
/// <item><description><b>DocumentModel.Drawings.ExtensionList:</b> General DrawingML extensions for shapes, effects, and visual elements</description></item>
/// <item><description><b>BlipExtensionList:</b> Specific to image/picture data and image-specific features</description></item>
/// <item><description><b>ConnectorLockingExtensionList:</b> Specific to connector locking and attachment behaviors</description></item>
/// <item><description><b>OfficeArtExtensionList:</b> Container for multiple types of Office Art extensions</description></item>
/// <item><description><b>DocumentModel.ExtensionList:</b> General extensions for any Office Open XML element (not DrawingML-specific)</description></item>
/// </list>
/// </para>
/// <para>
/// Each <see cref="IExtension"/> in the collection typically contains a UriString identifier, visual properties, metadata, and version information.
/// </para>
/// </remarks>
[OpenXmlType(typeof(DXD.ExtensionList))]
public class ExtensionList : ModelElementCollection<Extension, DXD.ExtensionList, DXD.Extension>
{
}