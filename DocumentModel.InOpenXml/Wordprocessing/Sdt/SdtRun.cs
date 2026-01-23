namespace DocumentModel.Wordprocessing;

/// <summary>
/// Structured document tag around one or more inline-level structures (runs, DrawingML objects, fields, etc.) in the current paragraph.
/// This class represents a collection of structured document tag run content and provides properties for tag configuration and end character formatting, enabling advanced handling of inline-level structured document tags.
/// </summary>
public class SdtRun: ModelElement<DXW.SdtRun>, IParagraphContent, ISdtRunContent, IBidirectionalContent, DMM.IMathArgumentContent
{
  
  /// <summary>
  /// Specifies the set of properties applied to this structured document tag.
  /// </summary>
  public SdtProperties? SdtProperties { get; set; }
  
  /// <summary>
  /// Specifies the properties applied to the physical character that delimits the end of a structured document tag.
  /// </summary>
  public SdtEndCharProperties? SdtEndCharProperties { get; set; }
}