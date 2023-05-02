namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Multi Level String Reference.
/// </summary>
public class MultiLevelStringReference: ModelElement
{
  /// <summary>
  ///   Formula.
  /// </summary>
  public string? Formula { get; set; }

  /// <summary>
  ///   MultiLevelStringCache.
  /// </summary>
  public MultiLevelStringCache? MultiLevelStringCache { get; set; }

  /// <summary>
  ///   MultiLvlStrRefExtensionList.
  /// </summary>
  public MultiLvlStrRefExtensionList? MultiLvlStrRefExtensionList { get; set; }
}