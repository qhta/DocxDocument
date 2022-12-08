namespace DocumentModel.Drawings;

/// <summary>
/// Color Transform Category.
/// </summary>
public class ColorTransformCategoryImpl: ModelElementImpl, ColorTransformCategory
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory?)_OpenXmlElement;
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
