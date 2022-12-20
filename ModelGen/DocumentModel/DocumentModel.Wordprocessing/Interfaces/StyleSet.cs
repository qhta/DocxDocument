namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the StyleSet Class.
/// </summary>
public partial interface StyleSet
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? Id { get; set; }
  
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffKind? Val { get; set; }
  
}
