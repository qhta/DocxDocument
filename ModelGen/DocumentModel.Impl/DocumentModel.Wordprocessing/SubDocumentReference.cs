namespace DocumentModel.Wordprocessing;

/// <summary>
/// Anchor for Subdocument Location.
/// </summary>
public class SubDocumentReference: ISubDocumentReference
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
