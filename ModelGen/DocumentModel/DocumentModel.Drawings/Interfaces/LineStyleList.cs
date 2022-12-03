namespace DocumentModel.Drawings;

/// <summary>
/// Line Style List.
/// </summary>
public interface LineStyleList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Outline>? Outlines { get ; set; }
  
}
