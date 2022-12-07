namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the StyleSet Class.
/// </summary>
public interface StyleSet
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public OnOffKind? Val { get ; set; }
  
}
