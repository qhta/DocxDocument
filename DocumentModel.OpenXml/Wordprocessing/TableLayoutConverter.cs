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
  
  public static DocumentModel.Wordprocessing.TableLayout? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TableLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableLayout();
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableLayout? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TableLayout, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      return openXmlElement;
    }
    return default;
  }
}
