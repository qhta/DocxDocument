namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ColorMap interface.
/// </summary>
public interface ColorMap: IModelElement
{
  public ExtensionList? ExtensionList { get; set; }
}