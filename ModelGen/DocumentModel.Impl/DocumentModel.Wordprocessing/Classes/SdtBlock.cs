namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtBlock Class.
/// </summary>
public class SdtBlockImpl: DocumentModel.Wordprocessing.SdtElementImpl, SdtBlock
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
