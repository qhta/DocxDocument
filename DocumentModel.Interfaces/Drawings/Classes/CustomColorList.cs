namespace DocumentModel.Drawings;

/// <summary>
///   Defines the CustomColorList interface.
/// </summary>
public interface CustomColorList: IModelElement
{
  public Collection<CustomColor>? CustomColors { get; set; }
}