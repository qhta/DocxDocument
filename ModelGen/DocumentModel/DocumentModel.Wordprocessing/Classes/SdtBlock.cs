namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtBlock Class.
/// </summary>
public class SdtBlock: DocumentModel.Wordprocessing.SdtElement
{
  /// <summary>
  /// Block-Level Structured Document Tag Content.
  /// </summary>
  public SdtContentBlock? SdtContentBlock
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
