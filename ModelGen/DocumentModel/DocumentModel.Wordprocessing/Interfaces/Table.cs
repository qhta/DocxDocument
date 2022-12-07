namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Table Class.
/// </summary>
public interface Table
{
  public TableProperties? TableProperties { get ; set; }
  
  public TableGrid? TableGrid { get ; set; }
  
}
