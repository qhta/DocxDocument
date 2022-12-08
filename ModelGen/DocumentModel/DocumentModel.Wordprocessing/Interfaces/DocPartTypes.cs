namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Types.
/// </summary>
public interface DocPartTypes
{
  /// <summary>
  /// Entry Is Of All Types
  /// </summary>
  public Boolean? All { get ; set; }
  
  public Collection<DocPartKind>? Items { get ; set; }
  
}
