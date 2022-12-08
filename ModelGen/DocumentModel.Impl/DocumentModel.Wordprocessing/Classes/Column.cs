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
  
  /// <summary>
  /// Column Width
  /// </summary>
  public String? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// Space Before Following Column
  /// </summary>
  public String? Space
  {
    get;
    set;
  }
  
}
