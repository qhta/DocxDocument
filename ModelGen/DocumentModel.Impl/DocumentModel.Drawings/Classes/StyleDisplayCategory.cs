namespace DocumentModel.Drawings;

/// <summary>
/// Category.
/// </summary>
public class StyleDisplayCategoryImpl: ModelElementImpl, StyleDisplayCategory
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Category Type
  /// </summary>
  public String? Type
  {
    get => (String?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Priority
  /// </summary>
  public UInt32? Priority
  {
    get => (UInt32?)OpenXmlElement?.Priority?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Priority = (System.UInt32?)value;
    }
  }
  
}
