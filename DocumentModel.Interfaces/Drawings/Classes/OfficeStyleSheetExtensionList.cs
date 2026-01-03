namespace DocumentModel.Drawings;

/// <summary>
///   Defines the OfficeStyleSheetExtensionList interface.
/// </summary>
public interface OfficeStyleSheetExtensionList: IModelElement
{
  public Collection<OfficeStyleSheetExtension>? OfficeStyleSheetExtensions { get; set; }
}