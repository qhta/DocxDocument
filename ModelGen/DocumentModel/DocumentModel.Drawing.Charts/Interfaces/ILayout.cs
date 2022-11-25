namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Layout.
/// </summary>
public interface ILayout // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Manual Layout.
  /// </summary>
  public DocumentModel.Drawing.Charts.IManualLayout? ManualLayout { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
