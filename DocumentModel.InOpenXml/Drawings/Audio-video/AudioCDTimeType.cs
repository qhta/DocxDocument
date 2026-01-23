namespace DocumentModel.Drawings;
/// <summary>
/// Represents an audio CD time type, specifying the track number and time position on an audio CD.
/// </summary>
public partial class AudioCDTimeType : ModelElement<DXD.AudioCDTimeType>
{
    /// <summary>
    /// Track number on the audio CD.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.AudioCDTimeType.Track))]
    public Byte? Track { get => _Track; set => UpdateField(ref _Track, value, nameof(Track)); }

    private Byte? _Track;
    /// <summary>
    /// Time position on the audio CD, typically in milliseconds or frames.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.AudioCDTimeType.Time))]
    public UInt32? Time { get => _Time; set => UpdateField(ref _Time, value, nameof(Time)); }

    private UInt32? _Time;
}