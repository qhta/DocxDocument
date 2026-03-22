namespace DocumentModel.Drawings;
/// <summary>
/// Represents audio sourced from a CD, including start and end times and optional extension data.
/// </summary>
[OpenXmlType(typeof(DXD.AudioFromCD))]
public partial class AudioFromCD : ModelElement<DXD.AudioFromCD>
{
 /// <summary>
 /// Start time of the audio segment from the CD.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AudioFromCD.StartTime))]
 public AudioCDTimeType? StartTime { get => _StartTime; set => UpdateField(ref _StartTime, value, nameof(StartTime)); }
 private AudioCDTimeType? _StartTime;
 /// <summary>
 /// End time of the audio segment from the CD.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.AudioFromCD.EndTime))]
 public AudioCDTimeType? EndTime { get => _EndTime; set => UpdateField(ref _EndTime, value, nameof(EndTime)); }
 private AudioCDTimeType? _EndTime;
}