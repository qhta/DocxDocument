namespace DocumentModel.Wordprocessing;

/// <summary>
/// Previous Table Grid.
/// </summary>
public class PreviousTableGridImpl: ModelElementImpl, PreviousTableGrid
{
  public DocumentFormat.OpenXml.Wordprocessing.PreviousTableGrid? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.PreviousTableGrid?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<GridColumn>? GridColumns
  {
    get;
    set;
  }
  
}
