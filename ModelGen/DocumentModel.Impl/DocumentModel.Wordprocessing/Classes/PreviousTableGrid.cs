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
  
  public PreviousTableGridImpl(): base() {}
  
  public PreviousTableGridImpl(DocumentFormat.OpenXml.Wordprocessing.PreviousTableGrid openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<GridColumn>? GridColumns
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
