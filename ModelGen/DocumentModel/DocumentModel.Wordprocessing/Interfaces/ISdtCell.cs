namespace DocumentModel.Wordprocessing;

/// <summary>
/// Cell-Level Structured Document Tag.
/// </summary>
public interface ISdtCell // : DocumentModel.Wordprocessing.ISdtElement
{
  /// <summary>
  /// Cell-Level Structured Document Tag Content.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? SdtContentCell { get ; set; }
  
}
