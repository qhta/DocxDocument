namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Layout.
/// </summary>
public interface ILayout // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Manual Layout.
  /// </summary>
  public IManualLayout? ManualLayout { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
