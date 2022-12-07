namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableLayout Class.
/// </summary>
public class TableLayoutImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.TableLayout>, TableLayout
{
  /// <summary>
  /// Table Layout Setting
  /// </summary>
  public TableLayoutKind? Type
  {
    get => (TableLayoutKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Wordprocessing.TableLayoutValues?)value;
    }
  }
  
}
