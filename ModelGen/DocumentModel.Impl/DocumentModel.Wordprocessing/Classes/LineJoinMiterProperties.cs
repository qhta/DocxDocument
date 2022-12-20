namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LineJoinMiterProperties Class.
/// </summary>
public partial class LineJoinMiterPropertiesImpl: ModelElementImpl, LineJoinMiterProperties
{
  public DocumentFormat.OpenXml.Office2010.Word.LineJoinMiterProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.LineJoinMiterProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LineJoinMiterPropertiesImpl(): base() {}
  
  public LineJoinMiterPropertiesImpl(DocumentFormat.OpenXml.Office2010.Word.LineJoinMiterProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// lim, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Limit
  {
    get => (System.Int32?)OpenXmlElement?.Limit?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Limit = (System.Int32?)value;
    }
  }
  
}
