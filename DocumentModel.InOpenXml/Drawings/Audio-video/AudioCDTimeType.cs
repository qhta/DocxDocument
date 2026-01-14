namespace DocumentModel.Drawings;

/// <summary>
/// Represents an audio CD time type, specifying the track number and time position on an audio CD.
/// </summary>
public class AudioCDTimeType: ModelElement
{
  /// <summary>
  /// Track number on the audio CD.
  /// </summary>
  public Byte? Track { get; set; }

  /// <summary>
  /// Time position on the audio CD, typically in milliseconds or frames.
  /// </summary>
  public UInt32? Time { get; set; }
}