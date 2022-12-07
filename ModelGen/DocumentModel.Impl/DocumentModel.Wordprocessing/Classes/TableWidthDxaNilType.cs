namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableWidthDxaNilType Class.
/// </summary>
public class TableWidthDxaNilTypeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType>, TableWidthDxaNilType
{
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
