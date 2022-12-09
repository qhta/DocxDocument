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
    get => (String?)OpenXmlElement?.Link?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Link = (System.String?)value;
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList4? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
