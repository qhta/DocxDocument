namespace DocumentModel.Wordprocessing;

/// <summary>
/// Row-Level Structured Document Tag.
/// </summary>
public class SdtRowImpl: DocumentModel.Wordprocessing.SdtElementImpl, SdtRow
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
