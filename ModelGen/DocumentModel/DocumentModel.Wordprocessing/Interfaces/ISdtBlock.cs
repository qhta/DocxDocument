namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtBlock Class.
/// </summary>
public interface ISdtBlock // : DocumentModel.Wordprocessing.ISdtElement
{
  /// <summary>
  /// Block-Level Structured Document Tag Content.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? SdtContentBlock { get ; set; }
  
}
