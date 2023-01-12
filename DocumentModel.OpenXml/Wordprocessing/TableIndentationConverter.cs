namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableIndentation Class.
/// </summary>
public static class TableIndentationConverter
{
  /// <summary>
  /// w
  /// </summary>
  public static Int32? GetWidth(DocumentFormat.OpenXml.Wordprocessing.TableIndentation? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Wordprocessing.TableIndentation? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }
  
  /// <summary>
  /// type
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthUnitKind? GetType(DocumentFormat.OpenXml.Wordprocessing.TableIndentation? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DocumentModel.Wordprocessing.TableWidthUnitKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Wordprocessing.TableIndentation? openXmlElement, DocumentModel.Wordprocessing.TableWidthUnitKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DocumentModel.Wordprocessing.TableWidthUnitKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.TableIndentation? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TableIndentation? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableIndentation();
      value.Width = GetWidth(openXmlElement);
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableIndentation? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TableIndentation, new()
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
