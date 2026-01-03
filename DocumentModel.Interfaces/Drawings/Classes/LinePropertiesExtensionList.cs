namespace DocumentModel.Drawings;

/// <summary>
///   Future extensions..
/// </summary>
public interface LinePropertiesExtensionList: IModelElement
{
  public Collection<LinePropertiesExtension>? LinePropertiesExtensions { get; set; }
}