namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Grid Column Definitions.
/// </summary>
public class TableGridChangeImpl: ModelElementImpl, TableGridChange
{
  public DocumentFormat.OpenXml.Wordprocessing.TableGridChange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableGridChange?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id
  {
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Previous Table Grid.
  /// </summary>
  public PreviousTableGrid? PreviousTableGrid
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
