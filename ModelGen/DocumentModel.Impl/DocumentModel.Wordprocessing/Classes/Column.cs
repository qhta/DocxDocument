namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Column Definition.
/// </summary>
public class ColumnImpl: ModelElementImpl, Column
{
  public DocumentFormat.OpenXml.Wordprocessing.Column? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Column?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ColumnImpl(): base() {}
  
  public ColumnImpl(DocumentFormat.OpenXml.Wordprocessing.Column openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Column Width
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
  
  /// <summary>
  /// Space Before Following Column
  /// </summary>
  public String? Space
  {
    get => (System.String?)OpenXmlElement?.Space?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Space = (System.String?)value;
    }
  }
  
}
