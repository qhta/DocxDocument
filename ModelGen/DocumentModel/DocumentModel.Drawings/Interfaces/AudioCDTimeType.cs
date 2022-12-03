namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AudioCDTimeType Class.
/// </summary>
public interface AudioCDTimeType // : System.Boolean
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
