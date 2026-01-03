namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the ExtensionList Class.
/// </summary>
public interface ExtensionList: IModelElement
{
  public Collection<Extension2>? Extension2s { get; set; }
}