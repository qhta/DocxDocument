namespace DocumentModel.Drawings;

/// <summary>
/// Reflection Effect.
/// </summary>
public class ReflectionImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Reflection>, Reflection
{
  /// <summary>
  /// Shadow Alignment
  /// </summary>
  public RectangleAlignmentKind? Alignment
  {
    get => (RectangleAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues?)value;
    }
  }
  
}
