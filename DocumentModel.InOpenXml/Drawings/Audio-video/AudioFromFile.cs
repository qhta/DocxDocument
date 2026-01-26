namespace DocumentModel.Drawings;
/// <summary>
/// Represents audio sourced from a file, including a linked relationship ID and optional extension data.
/// </summary>
[OpenXmlType(typeof(DXD.AudioFromFile))]
public partial class AudioFromFile : ModelElement<DXD.AudioFromFile>, IExtendableElement
{
 /// <summary>
 /// Linked relationship ID that references the audio file.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AudioFromFile.Link))]
 [OpenXmlElement(typeof(DXD.AudioFromFile))]
 public string? Link { get => _Link; set => UpdateField(ref _Link, value, nameof(Link)); }

 private string? _Link;
 [OpenXmlProperty(nameof(DXD.AudioFromFile.ExtensionList))]
 [OpenXmlElement(typeof(DXD.AudioFromFile))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

 private ExtensionList? _ExtensionList;
}