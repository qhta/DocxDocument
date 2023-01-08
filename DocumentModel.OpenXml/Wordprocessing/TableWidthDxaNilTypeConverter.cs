namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableWidthDxaNilType Class.
/// </summary>
public static class TableWidthDxaNilTypeConverter
{
  /// <summary>
  /// w
  /// </summary>
  public static Int16? GetWidth(DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType? openXmlElement, Int16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// type
  /// </summary>
  public static DocumentModel.Wordprocessing.TableWidthKind? GetType(DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthValues, DocumentModel.Wordprocessing.TableWidthKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType? openXmlElement, DocumentModel.Wordprocessing.TableWidthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthValues, DocumentModel.Wordprocessing.TableWidthKind>(value);
  }
  
}
