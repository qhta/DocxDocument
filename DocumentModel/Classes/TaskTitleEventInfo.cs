namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the TaskTitleEventInfo Class.
/// </summary>
public class TaskTitleEventInfo: ModelElement
{
  /// <summary>
  ///   title, this property is Ionly available Iin Office 2021 and later.
  /// </summary>
  public string? Title { get; set; }
}
