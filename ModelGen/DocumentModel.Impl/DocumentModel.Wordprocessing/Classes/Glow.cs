namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Glow Class.
/// </summary>
public class GlowImpl: ModelElementImpl, Glow
{
  public DocumentFormat.OpenXml.Office2010.Word.Glow? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.Glow?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GlowImpl(): base() {}
  
  public GlowImpl(DocumentFormat.OpenXml.Office2010.Word.Glow openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// rad, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? GlowRadius
  {
    get => (System.Int64?)OpenXmlElement?.GlowRadius?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GlowRadius = (System.Int64?)value;
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
