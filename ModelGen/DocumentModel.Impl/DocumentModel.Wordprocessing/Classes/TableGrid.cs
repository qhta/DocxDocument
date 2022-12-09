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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public TableGridChange? TableGridChange
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
