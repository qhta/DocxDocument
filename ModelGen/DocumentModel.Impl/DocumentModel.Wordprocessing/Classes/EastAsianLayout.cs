namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the EastAsianLayout Class.
/// </summary>
public class EastAsianLayoutImpl: ModelElementImpl, EastAsianLayout
{
  public DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public EastAsianLayoutImpl(): base() {}
  
  public EastAsianLayoutImpl(DocumentFormat.OpenXml.Wordprocessing.EastAsianLayout openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// East Asian Typography Run ID
  /// </summary>
  public Int32? Id
  {
    get => (Int32?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Two Lines in One
  /// </summary>
  public Boolean? Combine
  {
    get => (Boolean?)OpenXmlElement?.Combine?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Combine = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Display Brackets Around Two Lines in One
  /// </summary>
  public CombineBracketKind? CombineBrackets
  {
    get => (CombineBracketKind?)OpenXmlElement?.CombineBrackets?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CombineBrackets = (DocumentFormat.OpenXml.Wordprocessing.CombineBracketValues?)value;
    }
  }
  
  /// <summary>
  /// Horizontal in Vertical (Rotate Text)
  /// </summary>
  public Boolean? Vertical
  {
    get => (Boolean?)OpenXmlElement?.Vertical?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Vertical = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Compress Rotated Text to Line Height
  /// </summary>
  public Boolean? VerticalCompress
  {
    get => (Boolean?)OpenXmlElement?.VerticalCompress?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalCompress = (System.Boolean?)value;
    }
  }
  
}
