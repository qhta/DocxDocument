namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Layout Class.
/// </summary>
public interface ILayout // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Manual Layout.
  /// </summary>
  public DocumentModel.Drawing.IManualLayout? ManualLayout { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
