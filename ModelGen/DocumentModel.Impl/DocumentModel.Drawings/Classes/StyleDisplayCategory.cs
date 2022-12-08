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
    get;
    set;
  }
  
  /// <summary>
  /// Priority
  /// </summary>
  public UInt32? Priority
  {
    get;
    set;
  }
  
}
