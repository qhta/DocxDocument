namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableWidthType Class.
/// </summary>
public static class TableWidthTypeConverter
{
  /// <summary>
  /// Table Width Value
  /// </summary>
  private static String? GetWidth(DocumentFormat.OpenXml.Wordprocessing.TableWidthType openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static void SetWidth(DocumentFormat.OpenXml.Wordprocessing.TableWidthType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Width = new StringValue { Value = value };
    else
      openXmlElement.Width = null;
  }
  
  /// <summary>
  /// Table Width Type
  /// </summary>
  private static DocumentModel.Wordprocessing.TableWidthUnitKind? GetType(DocumentFormat.OpenXml.Wordprocessing.TableWidthType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DocumentModel.Wordprocessing.TableWidthUnitKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DocumentFormat.OpenXml.Wordprocessing.TableWidthType openXmlElement, DocumentModel.Wordprocessing.TableWidthUnitKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DocumentModel.Wordprocessing.TableWidthUnitKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.TableWidthType? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TableWidthType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableWidthType();
      value.Width = GetWidth(openXmlElement);
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableWidthType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TableWidthType, new()
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
