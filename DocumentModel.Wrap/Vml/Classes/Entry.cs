namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Regroup Entry.
/// </summary>
public class Entry: ModelElement
{
  /// <summary>
  ///   New Group ID
  /// </summary>
  public Int32? New { get; set; }

  /// <summary>
  ///   Old Group ID
  /// </summary>
  public Int32? Old { get; set; }
}