namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableIndentation Class.
/// </summary>
public class TableIndentationImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.TableIndentation>, TableIndentation
{
  /// <summary>
  /// type
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
