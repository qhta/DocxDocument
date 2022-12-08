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
  
  /// <summary>
  /// Caption Type Name
  /// </summary>
  public String? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Automatic Caption Placement
  /// </summary>
  public CaptionPositionKind? Position
  {
    get => (CaptionPositionKind?)OpenXmlElement?.Position?.Value;
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
    get;
    set;
  }
  
  /// <summary>
  /// Style for Chapter Headings
  /// </summary>
  public Int32? Heading
  {
    get;
    set;
  }
  
  /// <summary>
  /// Do Not Include Name In Caption
  /// </summary>
  public Boolean? NoLabel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Caption Numbering Format
  /// </summary>
  public NumberFormatKind? NumberFormat
  {
    get => (NumberFormatKind?)OpenXmlElement?.NumberFormat?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NumberFormat = (DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues?)value;
    }
  }
  
  /// <summary>
  /// Chapter Number/Item Index Separator
  /// </summary>
  public ChapterSeparatorKind? Separator
  {
    get => (ChapterSeparatorKind?)OpenXmlElement?.Separator?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Separator = (DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues?)value;
    }
  }
  
}
