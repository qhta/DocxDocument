namespace DocumentModel.Drawings;

/// <summary>
/// Layout.
/// </summary>
public interface Layout1
{
  /// <summary>
  /// Manual Layout.
  /// </summary>
  public ManualLayout? ManualLayout { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList3? ExtensionList { get ; set; }
  
}
