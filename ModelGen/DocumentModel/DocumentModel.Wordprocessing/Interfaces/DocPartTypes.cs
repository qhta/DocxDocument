namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Types.
/// </summary>
public interface DocPartTypes // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Entry Is Of All Types
  /// </summary>
  public Boolean? All { get ; set; }
  
  public Collection<DocPartKind>? DocPartTypes { get ; set; }
  
}
