namespace DocumentModel.Drawings;
/// <summary>
///   Represents an audio element in DrawingML that is sourced from an external file, including a linked relationship ID and optional extension data.
///   Enables embedding or linking audio content in Office documents, supporting extensibility for additional audio properties.
/// </summary>
[OpenXmlType(typeof(DXD.AudioFromFile))]
[DataContract]
[XmlRoot("AudioFromFile", Namespace = "DocumentModel.Drawings")]
public partial class AudioFromFile : ModelElement<DXD.AudioFromFile>, IExtendableElement
{
 /// <summary>
 ///   Relationship ID that references the external audio file, linking this element to the audio resource in the package.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AudioFromFile.Link))]
 public string? Link { get => _Link; set => UpdateField(ref _Link, value, nameof(Link)); }
 private string? _Link;

 /// <summary>
 ///   List of extension elements for the audio file, supporting extensibility and application-specific audio data.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AudioFromFile.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}