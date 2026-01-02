namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ExtensionList Class.
/// </summary>
public class ExtensionList: ModelElement
{
  public Collection<Extension>? Extensions { get; set; }
}