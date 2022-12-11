namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public class BorderTypeImpl: ModelElementImpl, BorderType
{
  public DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BorderTypeImpl(): base() {}
  
  public BorderTypeImpl(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Border Style
  /// </summary>
  public BorderKind? Type
  {
    get => (BorderKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues?)value;
    }
  }
  
  /// <summary>
  /// Border Width
  /// </summary>
  public Int32? Width
  {
    get => (Int32?)OpenXmlElement?.Width?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Width = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Border shadow
  /// </summary>
  public Boolean? Shadow
  {
    get => (Boolean?)OpenXmlElement?.Shadow?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Shadow = (System.Boolean?)value;
    }
  }
  
}
