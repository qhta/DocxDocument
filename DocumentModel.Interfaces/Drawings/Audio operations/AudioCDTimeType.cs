namespace DocumentModel.Drawings;

/// <summary>
/// Represents an audio CD time type, specifying the track number and time position on an audio CD.
/// </summary>
public interface AudioCDTimeType
{
  /// <summary>
  /// Gets or sets the track number on the audio CD.
  /// </summary>
  public Byte? Track { get; set; }

  /// <summary>
  /// Gets or sets the time position on the audio CD, typically in milliseconds or frames.
  /// </summary>
  public UInt32? Time { get; set; }
}