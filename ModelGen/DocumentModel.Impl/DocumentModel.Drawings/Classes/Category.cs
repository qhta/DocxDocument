namespace DocumentModel.Drawings;

/// <summary>
/// Category.
/// </summary>
public class CategoryImpl: ModelElementImpl, Category
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Category? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Category?)_OpenXmlElement;
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
