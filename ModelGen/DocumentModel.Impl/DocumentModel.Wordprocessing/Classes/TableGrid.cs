namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Grid.
/// </summary>
public class TableGridImpl: ModelElementImpl, TableGrid
{
  public DocumentFormat.OpenXml.Wordprocessing.TableGrid? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableGrid?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<GridColumn>? GridColumns
  {
    get;
    set;
  }
  
  public TableGridChange? TableGridChange
  {
    get;
    set;
  }
  
}
