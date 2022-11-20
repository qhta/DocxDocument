namespace DocumentModel.Drawing;

/// <summary>
/// QuickTime from File.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public class QuickTimeFromFile: IQuickTimeFromFile
{
  /// <summary>
  /// Linked Relationship ID
  /// </summary>
  public string? Link
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
