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
  
  public TableWidthDxaNilTypeImpl(): base() {}
  
  public TableWidthDxaNilTypeImpl(DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// w
  /// </summary>
  public Int16? Width
  {
    get => (System.Int16?)OpenXmlElement?.Width?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Width = (System.Int16?)value;
    }
  }
  
  /// <summary>
  /// type
  /// </summary>
  public DocumentModel.Wordprocessing.TableWidthKind? Type
  {
    get => (DocumentModel.Wordprocessing.TableWidthKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.TableWidthValues?)value;
    }
  }
  
}
