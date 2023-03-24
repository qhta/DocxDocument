namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Number Reference.
/// </summary>
public class NumberReference: ModelElement
{
  /// <summary>
  ///   Formula.
  /// </summary>
  public String? Formula { get; set; }

  /// <summary>
  ///   NumberingCache.
  /// </summary>
  public NumberingCache? NumberingCache { get; set; }

  /// <summary>
  ///   NumRefExtensionList.
  /// </summary>
  public NumRefExtensionList? NumRefExtensionList { get; set; }
}