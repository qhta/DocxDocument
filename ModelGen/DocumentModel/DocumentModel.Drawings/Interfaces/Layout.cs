namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Layout Class.
/// </summary>
public interface Layout // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Manual Layout.
  /// </summary>
  public ManualLayout? ManualLayout { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
