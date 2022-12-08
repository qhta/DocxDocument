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
  
  /// <summary>
  /// Positional Tab Stop Alignment
  /// </summary>
  public AbsolutePositionTabAlignmentKind? Alignment
  {
    get => (AbsolutePositionTabAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabAlignmentValues?)value;
    }
  }
  
  /// <summary>
  /// Positional Tab Base
  /// </summary>
  public AbsolutePositionTabPositioningBaseKind? RelativeTo
  {
    get => (AbsolutePositionTabPositioningBaseKind?)OpenXmlElement?.RelativeTo?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RelativeTo = (DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabPositioningBaseValues?)value;
    }
  }
  
  /// <summary>
  /// Tab Leader Character
  /// </summary>
  public AbsolutePositionTabLeaderCharKind? Leader
  {
    get => (AbsolutePositionTabLeaderCharKind?)OpenXmlElement?.Leader?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Leader = (DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabLeaderCharValues?)value;
    }
  }
  
}
