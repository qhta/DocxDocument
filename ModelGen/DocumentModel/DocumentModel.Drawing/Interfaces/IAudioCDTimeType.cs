namespace DocumentModel.Drawing;

/// <summary>
/// Defines the AudioCDTimeType Class.
/// </summary>
public interface IAudioCDTimeType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Track
  /// </summary>
  public Byte? Track { get ; set; }
  
  /// <summary>
  /// Time
  /// </summary>
  public UInt32? Time { get ; set; }
  
}
