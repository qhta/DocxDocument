namespace DocumentModel.Drawing;

/// <summary>
/// Defines the AudioCDTimeType Class.
/// </summary>
public interface IAudioCDTimeType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Track
  /// </summary>
  public System.Byte? Track { get ; set; }
  
  /// <summary>
  /// Time
  /// </summary>
  public System.UInt32? Time { get ; set; }
  
}
