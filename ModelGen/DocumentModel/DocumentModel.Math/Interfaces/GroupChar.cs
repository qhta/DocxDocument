namespace DocumentModel.Math;

/// <summary>
/// Group-Character Function.
/// </summary>
public interface GroupChar
{
  /// <summary>
  /// Group-Character Properties.
  /// </summary>
  public GroupCharProperties? GroupCharProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public Base? Base { get ; set; }
  
}
