namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the NumRefExtensionList Class.
/// </summary>
public class NumRefExtensionList: ModelElement
{
  public Collection<NumRefExtension>? NumRefExtensions { get; set; }
}
