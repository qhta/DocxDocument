namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ForegroundMark Class.
/// </summary>
public class ForegroundMarkImpl: ModelElementImpl, ForegroundMark
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// x1, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? FirstXCoordinate
  {
    get;
    set;
  }
  
  /// <summary>
  /// y1, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? FirstYCoordinate
  {
    get;
    set;
  }
  
  /// <summary>
  /// x2, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SecondXCoordinate
  {
    get;
    set;
  }
  
  /// <summary>
  /// y2, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SecondYCoordinate
  {
    get;
    set;
  }
  
}
