namespace DocumentModel.Wordprocessing;

/// <summary>
///  Structured document tag around one or more inline-level structures (runs, DrawingML objects, fields, etc.) in the current paragraph. 
/// </summary>
public class SdtRun: ElementCollection<ISdtRunContent>, IParagraphContent, ISdtRunContent, IBidirectionalContent, DMM.IMathArgumentContent
{
  /// <summary>
  ///  Specifies the set of properties which shall be applied to this structured document tag.
  /// </summary>
  public SdtProperties? SdtProperties { get; set; }

  /// <summary>
  /// Specifies the properties which shall be applied to the physical character which delimits the end of a structured document tag.
  /// </summary>
  public SdtEndCharProperties? SdtEndCharProperties { get; set; }
}