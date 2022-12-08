namespace DocumentModel.Drawings;

/// <summary>
/// QuickTime from File.
/// </summary>
public class QuickTimeFromFileImpl: ModelElementImpl, QuickTimeFromFile
{
  public DocumentFormat.OpenXml.Drawing.QuickTimeFromFile? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.QuickTimeFromFile?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Linked Relationship ID
  /// </summary>
  public String? Link
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
