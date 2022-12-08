namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableLayout Class.
/// </summary>
public class TableLayoutImpl: ModelElementImpl, TableLayout
{
  public DocumentFormat.OpenXml.Wordprocessing.TableLayout? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableLayout?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
