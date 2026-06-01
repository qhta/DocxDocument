namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the ITasks Class.
/// </summary>
public class ITasks: ModelElement
{
  public Collection<ITask>? Items { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}
