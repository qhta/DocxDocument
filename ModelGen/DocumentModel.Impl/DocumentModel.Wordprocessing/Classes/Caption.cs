namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Caption Type Definition.
/// </summary>
public class CaptionImpl: ModelElementImpl, Caption
{
  public DocumentFormat.OpenXml.Wordprocessing.Caption? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Caption?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CaptionImpl(): base() {}
  
  public CaptionImpl(DocumentFormat.OpenXml.Wordprocessing.Caption openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Caption Type Name
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Automatic Caption Placement
  /// </summary>
  public DocumentModel.Wordprocessing.CaptionPositionKind? Position
  {
    get => (DocumentModel.Wordprocessing.CaptionPositionKind?)OpenXmlElement?.Position?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Position = (DocumentFormat.OpenXml.Wordprocessing.CaptionPositionValues?)value;
    }
  }
  
  /// <summary>
  /// Include Chapter Number in Field for Caption
  /// </summary>
  public Boolean? ChapterNumber
  {
    get => (System.Boolean?)OpenXmlElement?.ChapterNumber?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ChapterNumber = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Style for Chapter Headings
  /// </summary>
  public Int32? Heading
  {
    get => (System.Int32?)OpenXmlElement?.Heading?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Heading = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Do Not Include Name In Caption
  /// </summary>
  public Boolean? NoLabel
  {
    get => (System.Boolean?)OpenXmlElement?.NoLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoLabel = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Caption Numbering Format
  /// </summary>
  public DocumentModel.Wordprocessing.NumberFormatKind? NumberFormat
  {
    get => (DocumentModel.Wordprocessing.NumberFormatKind?)OpenXmlElement?.NumberFormat?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NumberFormat = (DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues?)value;
    }
  }
  
  /// <summary>
  /// Chapter Number/Item Index Separator
  /// </summary>
  public DocumentModel.Wordprocessing.ChapterSeparatorKind? Separator
  {
    get => (DocumentModel.Wordprocessing.ChapterSeparatorKind?)OpenXmlElement?.Separator?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Separator = (DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues?)value;
    }
  }
  
}
