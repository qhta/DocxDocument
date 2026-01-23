namespace DocumentModel.Drawings;

/// <summary>
/// Represents audio sourced from a CD, including start and end times and optional extension data.
/// </summary>
public class AudioFromCD: ModelElement<DXD.AudioFromCD>
{
  /// <summary>
  /// Start time of the audio segment from the CD.
  /// </summary>
  public AudioCDTimeType? StartTime { get; set; }

  /// <summary>
  /// End time of the audio segment from the CD.
  /// </summary>
  public AudioCDTimeType? EndTime { get; set; }

}