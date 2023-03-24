namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the StringReference Class.
/// </summary>
public class StringReference: ModelElement
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