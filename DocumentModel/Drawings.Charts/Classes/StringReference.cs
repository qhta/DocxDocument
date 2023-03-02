namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the StringReference Class.
/// </summary>
public record StringReference
{
  /// <summary>
  ///   Formula.
  /// </summary>
  public String? Formula { get; set; }

  /// <summary>
  ///   StringCache.
  /// </summary>
  public StringCache? StringCache { get; set; }

  /// <summary>
  ///   StrRefExtensionList.
  /// </summary>
  public StrRefExtensionList? StrRefExtensionList { get; set; }
}