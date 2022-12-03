namespace DocumentModel.Drawings;

/// <summary>
/// Shape Adjust List.
/// </summary>
public interface AdjustList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Adjust>? Adjusts { get ; set; }
  
}
