namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableWidthDxaNilType Class.
/// </summary>
public static class TableWidthDxaNilTypeConverter
{
  /// <summary>
  /// w
  /// </summary>
  private static Int16? GetWidth(DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static void SetWidth(DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType openXmlElement, Int16? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// type
  /// </summary>
  private static DocumentModel.Wordprocessing.TableWidthKind? GetType(DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthValues, DocumentModel.Wordprocessing.TableWidthKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType openXmlElement, DocumentModel.Wordprocessing.TableWidthKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthValues, DocumentModel.Wordprocessing.TableWidthKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.TableWidthDxaNilType? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableWidthDxaNilType();
      value.Width = GetWidth(openXmlElement);
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableWidthDxaNilType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetType(openXmlElement, value?.Type);
      return openXmlElement;
    }
    return default;
  }
}
