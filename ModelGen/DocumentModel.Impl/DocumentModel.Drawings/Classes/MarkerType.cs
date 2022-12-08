namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MarkerType Class.
/// </summary>
public class MarkerTypeImpl: ModelElementImpl, MarkerType
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Relative X Coordinate.
  /// </summary>
  public virtual String? XPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// Relative Y Coordinate.
  /// </summary>
  public virtual String? YPosition
  {
    get;
    set;
  }
  
}
