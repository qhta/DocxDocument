namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Inline Drawing Object Extents.
/// </summary>
public class ExtentImpl: ModelElementImpl, Extent
{
  public DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Extent Length
  /// </summary>
  public Int64? Cx
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  public Int64? Cy
  {
    get;
    set;
  }
  
}
