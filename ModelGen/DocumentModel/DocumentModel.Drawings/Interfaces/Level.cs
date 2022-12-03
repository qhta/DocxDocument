namespace DocumentModel.Drawings;

/// <summary>
/// Level.
/// </summary>
public interface Level // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<StringPoint>? StringPoints { get ; set; }
  
}
