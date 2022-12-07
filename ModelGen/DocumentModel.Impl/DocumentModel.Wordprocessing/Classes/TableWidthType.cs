namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableWidthType Class.
/// </summary>
public class TableWidthTypeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.TableWidthType>, TableWidthType
{
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
