namespace DocumentModel.Math;

/// <summary>
/// Group-Character Function.
/// </summary>
public interface GroupChar
{
  /// <summary>
  /// Group-Character Properties.
  /// </summary>
  public DocumentModel.Math.GroupCharProperties? GroupCharProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.Base? Base { get ; set; }
  
}
