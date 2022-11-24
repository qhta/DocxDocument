namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the Layout Class.
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
