namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ExtraColorSchemeList interface.
/// </summary>
public interface ExtraColorSchemeList: IModelElement
{
  public Collection<ExtraColorScheme>? ExtraColorSchemes { get; set; }
}