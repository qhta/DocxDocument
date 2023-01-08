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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVal(DocumentFormat.OpenXml.Wordprocessing.TableRowHeight? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
  
}
