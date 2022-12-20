namespace DocumentModel.Math;

/// <summary>
/// Delimiter Function.
/// </summary>
public partial interface Delimiter
{
  /// <summary>
  /// Delimiter Properties.
  /// </summary>
  public DocumentModel.Math.DelimiterProperties? DelimiterProperties { get; set; }
  
  public Collection<DocumentModel.Math.Base>? Bases { get; set; }
  
}
