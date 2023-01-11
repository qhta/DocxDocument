namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableRowHeight Class.
/// </summary>
public static class TableRowHeightConverter
{
  /// <summary>
  /// Table Row Height
  /// </summary>
  public static UInt32? GetVal(DocumentFormat.OpenXml.Wordprocessing.TableRowHeight? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Wordprocessing.TableRowHeight? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = value;
  }
  
  /// <summary>
  /// Table Row Height Type
  /// </summary>
  public static DocumentModel.Wordprocessing.HeightRuleKind? GetHeightType(DocumentFormat.OpenXml.Wordprocessing.TableRowHeight? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues, DocumentModel.Wordprocessing.HeightRuleKind>(openXmlElement?.HeightType?.Value);
  }
  
  public static void SetHeightType(DocumentFormat.OpenXml.Wordprocessing.TableRowHeight? openXmlElement, DocumentModel.Wordprocessing.HeightRuleKind? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
