namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VbaSuppData Class.
/// </summary>
public partial interface VbaSuppData
{
  /// <summary>
  /// DocEvents.
  /// </summary>
  public DocumentModel.Wordprocessing.DocEvents? DocEvents { get; set; }
  
  /// <summary>
  /// Mcds.
  /// </summary>
  public DocumentModel.Wordprocessing.Mcds? Mcds { get; set; }
  
}
