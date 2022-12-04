namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtRun Class.
/// </summary>
public class SdtRun: DocumentModel.Wordprocessing.SdtElement
{
  /// <summary>
  /// Inline-Level Structured Document Tag Content.
  /// </summary>
  public SdtContentRun? SdtContentRun
  {
    get;
    set;
  }
  
  public override SdtProperties? SdtProperties
  {
    get;
    set;
  }
  
  public override SdtEndCharProperties? SdtEndCharProperties
  {
    get;
    set;
  }
  
}
