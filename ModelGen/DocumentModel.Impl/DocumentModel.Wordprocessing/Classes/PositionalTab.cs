namespace DocumentModel.Wordprocessing;

/// <summary>
/// Absolute Position Tab Character.
/// </summary>
public class PositionalTabImpl: ModelElementImpl, PositionalTab
{
  public DocumentFormat.OpenXml.Wordprocessing.PositionalTab? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.PositionalTab?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PositionalTabImpl(): base() {}
  
  public PositionalTabImpl(DocumentFormat.OpenXml.Wordprocessing.PositionalTab openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Positional Tab Stop Alignment
  /// </summary>
  public DocumentModel.Wordprocessing.AbsolutePositionTabAlignmentKind? Alignment
  {
    get => (DocumentModel.Wordprocessing.AbsolutePositionTabAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabAlignmentValues?)value;
    }
  }
  
  /// <summary>
  /// Positional Tab Base
  /// </summary>
  public DocumentModel.Wordprocessing.AbsolutePositionTabPositioningBaseKind? RelativeTo
  {
    get => (DocumentModel.Wordprocessing.AbsolutePositionTabPositioningBaseKind?)OpenXmlElement?.RelativeTo?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RelativeTo = (DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabPositioningBaseValues?)value;
    }
  }
  
  /// <summary>
  /// Tab Leader Character
  /// </summary>
  public DocumentModel.Wordprocessing.AbsolutePositionTabLeaderCharKind? Leader
  {
    get => (DocumentModel.Wordprocessing.AbsolutePositionTabLeaderCharKind?)OpenXmlElement?.Leader?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Leader = (DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabLeaderCharValues?)value;
    }
  }
  
}
