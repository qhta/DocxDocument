namespace DocumentModel.Math;

/// <summary>
/// Delimiter Function.
/// </summary>
public interface Delimiter
{
  /// <summary>
  /// Delimiter Properties.
  /// </summary>
  public DocumentModel.Math.DelimiterProperties? DelimiterProperties { get ; set; }
  
  public DocumentModel.Math.Base? Base { get ; set; }
  
}
