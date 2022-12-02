namespace DocumentModel.Wordprocessing;

/// <summary>
/// Child div Elements Contained within Current div.
/// </summary>
public interface IDivsChild // : DocumentModel.Wordprocessing.IDivsType
{
  public Collection<IDiv>? Divs { get ; set; }
  
}
