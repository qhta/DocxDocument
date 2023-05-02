namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TaskProgressEventInfo Class.
/// </summary>
public class TaskProgressEventInfo: ModelElement
{
  /// <summary>
  ///   percentComplete, this property is only available in Office 2021 and later.
  /// </summary>
  public Int32? PercentComplete { get; set; }
}