namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Table Class.
/// </summary>
public class TableImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.Table>, Table
{
  public TableProperties? TableProperties
  {
    get;
    set;
  }
  
  public TableGrid? TableGrid
  {
    get;
    set;
  }
  
}
