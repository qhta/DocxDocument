namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableWidthType Class.
/// </summary>
public static class TableWidthTypeConverter
{
  /// <summary>
  /// Table Width Value
  /// </summary>
  public static String? GetWidth(DocumentFormat.OpenXml.Wordprocessing.TableWidthType? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Wordprocessing.TableWidthType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Width = new StringValue { Value = value };
      else
        openXmlElement.Width = null;
  }
  
  /// <summary>
  /// Table Width Type
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthUnitKind? GetType(DocumentFormat.OpenXml.Wordprocessing.TableWidthType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DocumentModel.Wordprocessing.TableWidthUnitKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Wordprocessing.TableWidthType? openXmlElement, DocumentModel.Wordprocessing.TableWidthUnitKind? value)
  {
    if (openXmlElement != null)
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
