namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SolidColorFillProperties Class.
/// </summary>
public class SolidColorFillPropertiesImpl: ModelElementImpl, SolidColorFillProperties
{
  public DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SolidColorFillPropertiesImpl(): base() {}
  
  public SolidColorFillPropertiesImpl(DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
