namespace DocumentModel.Wordprocessing;

/// <summary>
/// Grid Column Definition.
/// </summary>
public partial class GridColumnImpl: ModelElementImpl, GridColumn
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.GridColumn? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.GridColumn?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public GridColumnImpl(): base() {}
  
  public GridColumnImpl(DocumentFormat.OpenXml.Wordprocessing.GridColumn openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Grid Column Width
  /// </summary>
  public String? Width
  {
    get => (System.String?)OpenXmlElement?.Width?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Width = (System.String?)value;
    }
  }
  
}
