namespace DocumentModel.Wordprocessing;

/// <summary>
/// Row-Level Structured Document Tag.
/// </summary>
public class SdtRow: DocumentModel.Wordprocessing.SdtElement
{
  /// <summary>
  /// Row-Level Structured Document Tag Content.
  /// </summary>
  public SdtContentRow? SdtContentRow
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
