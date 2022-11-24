namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtBlock Class.
/// </summary>
public interface ISdtBlock // : DocumentModel.Wordprocessing.ISdtElement
{
  /// <summary>
  /// Block-Level Structured Document Tag Content.
  /// </summary>
  public ISdtContentBlock? SdtContentBlock { get ; set; }
  
}
