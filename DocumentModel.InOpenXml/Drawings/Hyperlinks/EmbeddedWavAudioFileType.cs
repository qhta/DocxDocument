namespace DocumentModel.Drawings;
/// <summary>
///   Represents an embedded WAV audio file in a drawing object.
/// </summary>
public partial class EmbeddedWavAudioFileType : ModelElement<DXD.EmbeddedWavAudioFileType>
{
    /// <summary>
    ///   Relationship ID that references the embedded audio file.
    /// </summary>
    public string? Embed { get => _Embed; set => UpdateField(ref _Embed, value, nameof(Embed)); }

    private string? _Embed;
    /// <summary>
    ///   Name of the sound.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    ///   Determines whether it is a recognized Built-In Sound.
    /// </summary>
    public bool? BuiltIn { get; set; }
}