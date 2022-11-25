namespace DocumentModel.Wordprocessing;

/// <summary>
/// Row-Level Structured Document Tag.
/// </summary>
public interface ISdtRow // : DocumentModel.Wordprocessing.ISdtElement
{
  /// <summary>
  /// Row-Level Structured Document Tag Content.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? SdtContentRow { get ; set; }
  
}
