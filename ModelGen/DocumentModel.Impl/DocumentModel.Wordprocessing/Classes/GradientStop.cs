namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the GradientStop Class.
/// </summary>
public class GradientStopImpl: ModelElementImpl, GradientStop
{
  public DocumentFormat.OpenXml.Office2010.Word.GradientStop? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.GradientStop?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GradientStopImpl(): base() {}
  
  public GradientStopImpl(DocumentFormat.OpenXml.Office2010.Word.GradientStop openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// pos, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? StopPosition
  {
    get => (System.Int32?)OpenXmlElement?.StopPosition?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StopPosition = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public DocumentModel.Wordprocessing.RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public DocumentModel.Wordprocessing.SchemeColor? SchemeColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
