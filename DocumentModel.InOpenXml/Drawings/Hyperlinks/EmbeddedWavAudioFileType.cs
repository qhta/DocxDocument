namespace DocumentModel.Drawings;
/// <summary>
///   Represents an embedded WAV audio file in a drawing object.
/// </summary>
[OpenXmlType(typeof(DXD.EmbeddedWavAudioFileType))]
public partial class EmbeddedWavAudioFileType : ModelElement<DXD.EmbeddedWavAudioFileType>
{
 /// <summary>
 ///   Relationship ID that references the embedded audio file.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.EmbeddedWavAudioFileType.Embed))]
 /// <summary>
 ///   Relationship ID that references the embedded audio file.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EmbeddedWavAudioFileType))]
 public string? Embed { get => _Embed; set => UpdateField(ref _Embed, value, nameof(Embed)); }

 private string? _Embed;
 /// <summary>
 ///   FontName of the sound.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.EmbeddedWavAudioFileType.Name))]
 /// <summary>
 ///   FontName of the sound.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EmbeddedWavAudioFileType))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

 private string? _Name;
 /// <summary>
 ///   Determines whether it is a recognized Built-In Sound.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.EmbeddedWavAudioFileType.BuiltIn))]
 /// <summary>
 ///   Determines whether it is a recognized Built-In Sound.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EmbeddedWavAudioFileType))]
 public bool? BuiltIn { get => _BuiltIn; set => UpdateField(ref _BuiltIn, value, nameof(BuiltIn)); }

 private bool? _BuiltIn;
}