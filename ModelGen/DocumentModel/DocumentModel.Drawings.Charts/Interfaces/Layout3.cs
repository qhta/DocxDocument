namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Layout Class.
/// </summary>
public interface Layout3
{
  /// <summary>
  /// Manual Layout.
  /// </summary>
  public DocumentModel.Drawings.Charts.ManualLayout? ManualLayout { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
