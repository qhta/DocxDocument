namespace DocumentModel.Drawings;

/// <summary>
/// QuickTime from File.
/// </summary>
public class QuickTimeFromFileImpl: ModelElement<DocumentFormat.OpenXml.Drawing.QuickTimeFromFile>, QuickTimeFromFile
{
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
