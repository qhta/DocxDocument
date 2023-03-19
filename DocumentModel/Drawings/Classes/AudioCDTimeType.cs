namespace DocumentModel.Drawings;

/// <summary>
///   Defines the AudioCDTimeType Class.
/// </summary>
public class AudioCDTimeType: ModelElement
{
  /// <summary>
  ///   Track
  /// </summary>
  public Byte? Track { get; set; }

  /// <summary>
  ///   Time
  /// </summary>
  public UInt32? Time { get; set; }
}