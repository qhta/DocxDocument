namespace DocumentModel.Drawings;

/// <summary>
/// Stretch.
/// </summary>
public class StretchImpl: ModelElementImpl, Stretch
{
  public DocumentFormat.OpenXml.Drawing.Stretch? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Stretch?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Fill Rectangle.
  /// </summary>
  public RelativeRectangleType? FillRectangle
  {
    get;
    set;
  }
  
}
