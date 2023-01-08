namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableLayout Class.
/// </summary>
public static class TableLayoutConverter
{
  /// <summary>
  /// Table Layout Setting
  /// </summary>
  public static DocumentModel.Wordprocessing.TableLayoutKind? GetType(DocumentFormat.OpenXml.Wordprocessing.TableLayout? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableLayoutValues, DocumentModel.Wordprocessing.TableLayoutKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Wordprocessing.TableLayout? openXmlElement, DocumentModel.Wordprocessing.TableLayoutKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableLayoutValues, DocumentModel.Wordprocessing.TableLayoutKind>(value);
  }
  
}
