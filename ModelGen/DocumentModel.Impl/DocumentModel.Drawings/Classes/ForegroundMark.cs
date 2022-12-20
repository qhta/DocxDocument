namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ForegroundMark Class.
/// </summary>
public partial class ForegroundMarkImpl: ModelElementImpl, ForegroundMark
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ForegroundMarkImpl(): base() {}
  
  public ForegroundMarkImpl(DocumentFormat.OpenXml.Office2010.Drawing.ForegroundMark openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// x1, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? FirstXCoordinate
  {
    get => (System.Int32?)OpenXmlElement?.FirstXCoordinate?.Value;
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
    get => (System.Int32?)OpenXmlElement?.FirstYCoordinate?.Value;
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
    get => (System.Int32?)OpenXmlElement?.SecondXCoordinate?.Value;
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
    get => (System.Int32?)OpenXmlElement?.SecondYCoordinate?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SecondYCoordinate = (System.Int32?)value;
    }
  }
  
}
