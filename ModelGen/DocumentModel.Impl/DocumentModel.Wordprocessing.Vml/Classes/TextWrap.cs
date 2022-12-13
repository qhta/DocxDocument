namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
/// Text Wrapping.
/// </summary>
public class TextWrapImpl: ModelElementImpl, TextWrap
{
  public DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextWrapImpl(): base() {}
  
  public TextWrapImpl(DocumentFormat.OpenXml.Vml.Wordprocessing.TextWrap openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Wrapping type
  /// </summary>
  public DocumentModel.Wordprocessing.Vml.WrapKind? Type
  {
    get => (DocumentModel.Wordprocessing.Vml.WrapKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Vml.Wordprocessing.WrapValues?)value;
    }
  }
  
  /// <summary>
  /// Wrapping side
  /// </summary>
  public DocumentModel.Wordprocessing.Vml.WrapSideKind? Side
  {
    get => (DocumentModel.Wordprocessing.Vml.WrapSideKind?)OpenXmlElement?.Side?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Side = (DocumentFormat.OpenXml.Vml.Wordprocessing.WrapSideValues?)value;
    }
  }
  
  /// <summary>
  /// Horizontal Positioning Base
  /// </summary>
  public DocumentModel.Wordprocessing.Vml.HorizontalAnchorKind? AnchorX
  {
    get => (DocumentModel.Wordprocessing.Vml.HorizontalAnchorKind?)OpenXmlElement?.AnchorX?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AnchorX = (DocumentFormat.OpenXml.Vml.Wordprocessing.HorizontalAnchorValues?)value;
    }
  }
  
  /// <summary>
  /// Vertical Positioning Base
  /// </summary>
  public DocumentModel.Wordprocessing.Vml.VerticalAnchorKind? AnchorY
  {
    get => (DocumentModel.Wordprocessing.Vml.VerticalAnchorKind?)OpenXmlElement?.AnchorY?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AnchorY = (DocumentFormat.OpenXml.Vml.Wordprocessing.VerticalAnchorValues?)value;
    }
  }
  
}
