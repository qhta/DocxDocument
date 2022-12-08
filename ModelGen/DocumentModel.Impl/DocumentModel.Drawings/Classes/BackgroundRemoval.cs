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
  
  /// <summary>
  /// t, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeTop
  {
    get;
    set;
  }
  
  /// <summary>
  /// b, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeBottom
  {
    get;
    set;
  }
  
  /// <summary>
  /// l, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeLeft
  {
    get;
    set;
  }
  
  /// <summary>
  /// r, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? MarqueeRight
  {
    get;
    set;
  }
  
  public Collection<ForegroundMark>? ForegroundMarks
  {
    get;
    set;
  }
  
  public Collection<BackgroundMark>? BackgroundMarks
  {
    get;
    set;
  }
  
}
