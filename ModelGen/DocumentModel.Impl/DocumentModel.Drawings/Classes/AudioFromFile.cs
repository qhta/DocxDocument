namespace DocumentModel.Drawings;

/// <summary>
/// Audio from File.
/// </summary>
public class AudioFromFileImpl: ModelElement<DocumentFormat.OpenXml.Drawing.AudioFromFile>, AudioFromFile
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
