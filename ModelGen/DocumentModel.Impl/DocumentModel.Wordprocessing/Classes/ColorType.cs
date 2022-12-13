namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ColorType Class.
/// </summary>
public class ColorTypeImpl: ModelElementImpl, ColorType
{
  public DocumentFormat.OpenXml.Office2010.Word.ColorType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.ColorType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ColorTypeImpl(): base() {}
  
  public ColorTypeImpl(DocumentFormat.OpenXml.Office2010.Word.ColorType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// RgbColorModelHex.
  /// </summary>
  public virtual DocumentModel.Wordprocessing.RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// SchemeColor.
  /// </summary>
  public virtual DocumentModel.Wordprocessing.SchemeColor? SchemeColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
