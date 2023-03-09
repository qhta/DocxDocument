namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtRun Class.
/// </summary>
public class SdtRun: ElementCollection<ISdtRunElement>, ICommonRunElement
{
  ///// <summary>
  /////   Inline-Level Structured Document Tag Content.
  ///// </summary>
  //public SdtContentRun? SdtContentRun { get; set; }

  /// <summary>
  /// Properties of structured document tag.
  /// </summary>
  public SdtProperties? SdtProperties { get; set; }

  /// <summary>
  /// Properties which shall be applied to the physical character which delimits the end of a structured document tag.
  /// </summary>
  public SdtEndCharProperties? SdtEndCharProperties { get; set; }

}