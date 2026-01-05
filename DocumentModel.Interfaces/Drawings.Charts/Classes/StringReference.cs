namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the StringReference Class.
/// </summary>
public interface StringReference:
{
  /// <summary>
  ///   Formula.
  /// </summary>
  public string? Formula { get; set; }
  /// <summary>
  ///   StringCache.
  /// </summary>
  public StringCache? StringCache { get; set; }
  /// <summary>
  ///   StrRefExtensionList.
  /// </summary>
  public StrRefExtensionList? StrRefExtensionList { get; set; }
}