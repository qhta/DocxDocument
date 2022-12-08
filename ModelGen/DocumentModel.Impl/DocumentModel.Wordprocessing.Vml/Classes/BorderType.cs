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
    get;
    set;
  }
  
  /// <summary>
  /// Border shadow
  /// </summary>
  public Boolean? Shadow
  {
    get;
    set;
  }
  
}
