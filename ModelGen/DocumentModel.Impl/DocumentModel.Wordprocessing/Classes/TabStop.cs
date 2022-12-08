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
  
  /// <summary>
  /// Tab Stop Type
  /// </summary>
  public TabStopKind? Val
  {
    get => (TabStopKind?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.TabStopValues?)value;
    }
  }
  
  /// <summary>
  /// Tab Leader Character
  /// </summary>
  public TabStopLeaderCharKind? Leader
  {
    get => (TabStopLeaderCharKind?)OpenXmlElement?.Leader?.Value;
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
    get;
    set;
  }
  
}
