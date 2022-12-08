namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableWidthDxaNilType Class.
/// </summary>
public class TableWidthDxaNilTypeImpl: ModelElementImpl, TableWidthDxaNilType
{
  public DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// w
  /// </summary>
  public Int16? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// type
  /// </summary>
  public TableWidthKind? Type
  {
    get => (TableWidthKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.TableWidthValues?)value;
    }
  }
  
}
