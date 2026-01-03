namespace DocumentModel.Drawings;

/// <summary>
///   Override Color Mapping.
/// </summary>
public interface OverrideColorMapping: IModelElement
{
  public ExtensionList? ExtensionList { get; set; }
}