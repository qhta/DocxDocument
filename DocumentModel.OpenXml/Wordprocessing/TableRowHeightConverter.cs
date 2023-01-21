namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableRowHeight Class.
/// </summary>
public static class TableRowHeightConverter
{
  /// <summary>
  /// Table Row Height
  /// </summary>
  private static UInt32? GetVal(DXW.TableRowHeight openXmlElement)
  {
    return openXmlElement.Val?.Value;
  }
  
  private static void SetVal(DXW.TableRowHeight openXmlElement, UInt32? value)
  {
    openXmlElement.Val = value;
  }
  
  /// <summary>
  /// Table Row Height Type
  /// </summary>
  private static DMW.HeightRuleKind? GetHeightType(DXW.TableRowHeight openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues, DMW.HeightRuleKind>(openXmlElement?.HeightType?.Value);
  }
  
  private static void SetHeightType(DXW.TableRowHeight openXmlElement, DMW.HeightRuleKind? value)
  {
    openXmlElement.HeightType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues, DMW.HeightRuleKind>(value);
  }
  
  public static DMW.TableRowHeight? CreateModelElement(DXW.TableRowHeight? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableRowHeight();
      value.Val = GetVal(openXmlElement);
      value.HeightType = GetHeightType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableRowHeight? value)
    where OpenXmlElementType: DXW.TableRowHeight, new()
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
