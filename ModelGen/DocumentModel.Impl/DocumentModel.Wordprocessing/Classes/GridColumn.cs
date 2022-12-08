namespace DocumentModel.Wordprocessing;

/// <summary>
/// Grid Column Definition.
/// </summary>
public class GridColumnImpl: ModelElementImpl, GridColumn
{
  public DocumentFormat.OpenXml.Wordprocessing.GridColumn? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.GridColumn?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Grid Column Width
  /// </summary>
  public String? Width
  {
    get;
    set;
  }
  
}
