namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BackgroundRemoval Class.
/// </summary>
public class BackgroundRemovalImpl: ModelElementImpl, BackgroundRemoval
{
  public DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BackgroundRemovalImpl(): base() {}
  
  public BackgroundRemovalImpl(DocumentFormat.OpenXml.Office2010.Drawing.BackgroundRemoval openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// t, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeTop
  {
    get => (Int32?)OpenXmlElement?.MarqueeTop?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MarqueeTop = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// b, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeBottom
  {
    get => (Int32?)OpenXmlElement?.MarqueeBottom?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MarqueeBottom = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// l, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeLeft
  {
    get => (Int32?)OpenXmlElement?.MarqueeLeft?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MarqueeLeft = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// r, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeRight
  {
    get => (Int32?)OpenXmlElement?.MarqueeRight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MarqueeRight = (System.Int32?)value;
    }
  }
  
  public Collection<ForegroundMark>? ForegroundMarks
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<BackgroundMark>? BackgroundMarks
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
