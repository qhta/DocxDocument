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
    get => (Int32?)OpenXmlElement?.FirstXCoordinate?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FirstXCoordinate = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// y1, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? FirstYCoordinate
  {
    get => (Int32?)OpenXmlElement?.FirstYCoordinate?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FirstYCoordinate = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// x2, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SecondXCoordinate
  {
    get => (Int32?)OpenXmlElement?.SecondXCoordinate?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SecondXCoordinate = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// y2, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SecondYCoordinate
  {
    get => (Int32?)OpenXmlElement?.SecondYCoordinate?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SecondYCoordinate = (System.Int32?)value;
    }
  }
  
}
