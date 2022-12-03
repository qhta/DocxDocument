namespace DocumentModel.Math;

/// <summary>
/// Group-Character Function.
/// </summary>
public interface GroupChar // : DocumentModel.BaseTypes.ModelElement
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
