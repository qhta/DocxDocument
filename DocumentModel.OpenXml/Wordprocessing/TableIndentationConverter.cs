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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Wordprocessing.TableIndentation? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
  
}
