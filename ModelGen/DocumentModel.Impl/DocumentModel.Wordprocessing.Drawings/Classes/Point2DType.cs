namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Defines the Point2DType Class.
/// </summary>
public class Point2DTypeImpl: ModelElementImpl, Point2DType
{
  public DocumentFormat.OpenXml.Drawing.Wordprocessing.Point2DType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Wordprocessing.Point2DType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// X-Axis Coordinate
  /// </summary>
  public Int64? X
  {
    get;
    set;
  }
  
  /// <summary>
  /// Y-Axis Coordinate
  /// </summary>
  public Int64? Y
  {
    get;
    set;
  }
  
}
