namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Reflection Class.
/// </summary>
public class ReflectionImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Word.Reflection>, Reflection
{
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  public RectangleAlignmentKind? Alignment
  {
    get => (RectangleAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Office2010.Word.RectangleAlignmentValues?)value;
    }
  }
  
}
