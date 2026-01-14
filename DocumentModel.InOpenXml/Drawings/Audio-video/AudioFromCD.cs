namespace DocumentModel.Drawings;

/// <summary>
/// Represents audio sourced from a CD, including start and end times and optional extension data.
/// </summary>
public interface AudioFromCD: IExtendableElement
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