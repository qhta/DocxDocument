namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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