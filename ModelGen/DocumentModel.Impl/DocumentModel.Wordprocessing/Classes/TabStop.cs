namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom Tab Stop.
/// </summary>
public class TabStopImpl: ModelElementImpl, TabStop
{
  public DocumentFormat.OpenXml.Wordprocessing.TabStop? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TabStop?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TabStopImpl(): base() {}
  
  public TabStopImpl(DocumentFormat.OpenXml.Wordprocessing.TabStop openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Tab Stop Type
  /// </summary>
  public DocumentModel.Wordprocessing.TabStopKind? Val
  {
    get => (DocumentModel.Wordprocessing.TabStopKind?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.TabStopValues?)value;
    }
  }
  
  /// <summary>
  /// Tab Leader Character
  /// </summary>
  public DocumentModel.Wordprocessing.TabStopLeaderCharKind? Leader
  {
    get => (DocumentModel.Wordprocessing.TabStopLeaderCharKind?)OpenXmlElement?.Leader?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Leader = (DocumentFormat.OpenXml.Wordprocessing.TabStopLeaderCharValues?)value;
    }
  }
  
  /// <summary>
  /// Tab Stop Position
  /// </summary>
  public Int32? Position
  {
    get => (System.Int32?)OpenXmlElement?.Position?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Position = (System.Int32?)value;
    }
  }
  
}
