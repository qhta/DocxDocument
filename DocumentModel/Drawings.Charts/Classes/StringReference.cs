namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the StringReference Class.
/// </summary>
public class StringReference
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