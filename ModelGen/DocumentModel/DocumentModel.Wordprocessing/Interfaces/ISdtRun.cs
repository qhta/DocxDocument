namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtRun Class.
/// </summary>
public interface ISdtRun // : DocumentModel.Wordprocessing.ISdtElement
{
  /// <summary>
  /// Inline-Level Structured Document Tag Content.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? SdtContentRun { get ; set; }
  
}
