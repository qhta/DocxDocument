namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how a filter criterion relates to other filter criteria.
/// </summary>
public enum MsoFilterConjunction
{
  /// <summary>
  /// And conjunction.
  /// </summary>
  msoFilterConjunctionAnd,
  /// <summary>
  /// Or conjunction.
  /// </summary>
  msoFilterConjunctionOr
}
