namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the StrRefExtensionList Class.
/// </summary>
public class StrRefExtensionList: ModelElement
{
  public Collection<StrRefExtension>? StrRefExtensions { get; set; }
}