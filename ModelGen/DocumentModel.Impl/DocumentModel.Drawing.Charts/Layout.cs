namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Layout.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IManualLayout))]
public class Layout: ILayout
{
  /// <summary>
  /// Manual Layout.
  /// </summary>
  public IManualLayout? ManualLayout
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
