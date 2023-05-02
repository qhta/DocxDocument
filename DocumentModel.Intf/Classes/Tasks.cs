namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Tasks Class.
/// </summary>
public class Tasks: ModelElement
{
  public Collection<Task>? Items { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}