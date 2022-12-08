namespace DocumentModel.Drawings;

/// <summary>
/// Shape Extent.
/// </summary>
public class ExtentImpl: ModelElementImpl, Extent
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.Extent?)_OpenXmlElement;
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
