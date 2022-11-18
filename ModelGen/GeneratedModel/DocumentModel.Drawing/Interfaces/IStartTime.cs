namespace DocumentModel.Drawing;

/// <summary>
/// Audio Start Time.
/// </summary>
public interface IStartTime // : DocumentFormat.OpenXml.Drawing.AudioCDTimeType
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
