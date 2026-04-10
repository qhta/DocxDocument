namespace DocumentModel.Drawings;
/// <summary>
///   Represents a QuickTime video sourced from a file, including a reference to the linked relationship.
/// </summary>
[OpenXmlType(typeof(DXD.QuickTimeFromFile))]
[XmlRoot("QuickTimeFromFile", Namespace = "DocumentModel.Drawings")]
public partial class QuickTimeFromFile : ModelElement<DXD.QuickTimeFromFile>, IExtendableElement
{
 /// <summary>
 ///   Relationship ID that links to the QuickTime video file.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.QuickTimeFromFile.Link))]
 public string? Link { get => _Link; set => UpdateField(ref _Link, value, nameof(Link)); }

 private string? _Link;
 /// <summary>
 /// List of extension elements.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.QuickTimeFromFile.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

 private ExtensionList? _ExtensionList;
}