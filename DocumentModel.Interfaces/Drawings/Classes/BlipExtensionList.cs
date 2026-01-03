namespace DocumentModel.Drawings;

/// <summary>
///   Future extensions..
/// </summary>
public interface BlipExtensionList: IModelElement
{
  public Collection<BlipExtension>? BlipExtensions { get; set; }
}