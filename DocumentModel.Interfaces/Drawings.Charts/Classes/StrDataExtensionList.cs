namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the StrDataExtensionList Class.
/// </summary>
public interface StrDataExtensionList: IModelElement
{
  public Collection<StrDataExtension>? StrDataExtensions { get; set; }
}