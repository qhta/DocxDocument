namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TaskTitleEventInfo Class.
/// </summary>
public class TaskTitleEventInfo: ModelElement
{
  /// <summary>
  ///   title, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Title { get; set; }
}