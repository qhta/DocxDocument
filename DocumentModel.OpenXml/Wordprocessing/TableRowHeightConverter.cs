namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableRowHeight Class.
/// </summary>
public static class TableRowHeightConverter
{
  /// <summary>
  /// Table Row Height
  /// </summary>
  private static UInt32? GetVal(DocumentFormat.OpenXml.Wordprocessing.TableRowHeight openXmlElement)
  {
    return openXmlElement.Val?.Value;
  }
  
  private static void SetVal(DocumentFormat.OpenXml.Wordprocessing.TableRowHeight openXmlElement, UInt32? value)
  {
    openXmlElement.Val = value;
  }
  
  /// <summary>
  /// Table Row Height Type
  /// </summary>
  private static DocumentModel.Wordprocessing.HeightRuleKind? GetHeightType(DocumentFormat.OpenXml.Wordprocessing.TableRowHeight openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues, DocumentModel.Wordprocessing.HeightRuleKind>(openXmlElement?.HeightType?.Value);
  }
  
  private static void SetHeightType(DocumentFormat.OpenXml.Wordprocessing.TableRowHeight openXmlElement, DocumentModel.Wordprocessing.HeightRuleKind? value)
  {
    openXmlElement.HeightType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues, DocumentModel.Wordprocessing.HeightRuleKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.TableRowHeight? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TableRowHeight? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableRowHeight();
      value.Val = GetVal(openXmlElement);
      value.HeightType = GetHeightType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableRowHeight? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TableRowHeight, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetHeightType(openXmlElement, value?.HeightType);
      return openXmlElement;
    }
    return default;
  }
}
