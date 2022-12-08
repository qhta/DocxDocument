namespace DocumentModel.Wordprocessing;

/// <summary>
/// Child div Elements Contained within Current div.
/// </summary>
public interface DivsChild
{
  public Collection<Div>? Divs { get ; set; }
  
}
