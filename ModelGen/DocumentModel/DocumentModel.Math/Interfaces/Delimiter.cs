namespace DocumentModel.Math;

/// <summary>
/// Delimiter Function.
/// </summary>
public interface Delimiter // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Delimiter Properties.
  /// </summary>
  public DelimiterProperties? DelimiterProperties { get ; set; }
  
  public Collection<Base>? Bases { get ; set; }
  
}
