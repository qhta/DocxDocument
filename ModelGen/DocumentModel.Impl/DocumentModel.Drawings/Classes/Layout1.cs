namespace DocumentModel.Drawings;

/// <summary>
/// Layout.
/// </summary>
public class Layout1Impl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.Layout>, Layout1
{
  /// <summary>
  /// Manual Layout.
  /// </summary>
  public ManualLayout? ManualLayout
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
