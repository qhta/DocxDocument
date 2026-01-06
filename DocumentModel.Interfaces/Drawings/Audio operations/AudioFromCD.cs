namespace DocumentModel.Drawings;

/// <summary>
/// Represents audio sourced from a CD, including start and end times and optional extension data.
/// </summary>
public interface AudioFromCD
{
  /// <summary>
  /// Gets or sets the start time of the audio segment from the CD.
  /// </summary>
  public AudioCDTimeType? StartTime { get; set; }

  /// <summary>
  /// Gets or sets the end time of the audio segment from the CD.
  /// </summary>
  public AudioCDTimeType? EndTime { get; set; }

  /// <summary>
  /// Gets or sets the extension list containing additional metadata or custom extensions.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}