namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageNumberType Class.
/// </summary>
public class PageNumberTypeImpl: ModelElementImpl, PageNumberType
{
  public DocumentFormat.OpenXml.Wordprocessing.PageNumberType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.PageNumberType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PageNumberTypeImpl(): base() {}
  
  public PageNumberTypeImpl(DocumentFormat.OpenXml.Wordprocessing.PageNumberType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Page Number Format
  /// </summary>
  public DocumentModel.Wordprocessing.NumberFormatKind? Format
  {
    get => (DocumentModel.Wordprocessing.NumberFormatKind?)OpenXmlElement?.Format?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Format = (DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues?)value;
    }
  }
  
  /// <summary>
  /// Starting Page Number
  /// </summary>
  public Int32? Start
  {
    get => (System.Int32?)OpenXmlElement?.Start?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Start = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Chapter Heading Style
  /// </summary>
  public Byte? ChapterStyle
  {
    get => (System.Byte?)OpenXmlElement?.ChapterStyle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ChapterStyle = (System.Byte?)value;
    }
  }
  
  /// <summary>
  /// Chapter Separator Character
  /// </summary>
  public DocumentModel.Wordprocessing.ChapterSeparatorKind? ChapterSeparator
  {
    get => (DocumentModel.Wordprocessing.ChapterSeparatorKind?)OpenXmlElement?.ChapterSeparator?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ChapterSeparator = (DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues?)value;
    }
  }
  
}
