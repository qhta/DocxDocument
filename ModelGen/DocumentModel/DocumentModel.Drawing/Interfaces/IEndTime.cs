namespace DocumentModel.Drawing;

/// <summary>
/// Audio End Time.
/// </summary>
public interface IEndTime // : DocumentFormat.OpenXml.Drawing.AudioCDTimeType
{
  /// <summary>
  /// Track
  /// </summary>
  public byte? Track { get ; set; }
  
  /// <summary>
  /// Time
  /// </summary>
  public uint? Time { get ; set; }
  
}
