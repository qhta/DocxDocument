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
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Wordprocessing.TableWidthType? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
  
}
