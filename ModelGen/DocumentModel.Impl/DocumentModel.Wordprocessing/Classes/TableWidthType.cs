namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableWidthType Class.
/// </summary>
public class TableWidthTypeImpl: ModelElementImpl, TableWidthType
{
  public DocumentFormat.OpenXml.Wordprocessing.TableWidthType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableWidthType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Table Width Value
  /// </summary>
  public String? Width
  {
    get => (String?)OpenXmlElement?.Width?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Width = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Table Width Type
  /// </summary>
  public TableWidthUnitKind? Type
  {
    get => (TableWidthUnitKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues?)value;
    }
  }
  
}
