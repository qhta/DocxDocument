namespace DocumentModel.Drawings;

/// <summary>
/// Video from File.
/// </summary>
public class VideoFromFileImpl: ModelElement<DocumentFormat.OpenXml.Drawing.VideoFromFile>, VideoFromFile
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
