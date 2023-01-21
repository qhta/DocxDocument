namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableWidthType Class.
/// </summary>
public static class TableWidthTypeConverter
{
  /// <summary>
  /// Table Width Value
  /// </summary>
  private static String? GetWidth(DXW.TableWidthType openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  private static void SetWidth(DXW.TableWidthType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Width = new StringValue { Value = value };
    else
      openXmlElement.Width = null;
  }
  
  /// <summary>
  /// Table Width Type
  /// </summary>
  private static DMW.TableWidthUnitKind? GetType(DXW.TableWidthType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DMW.TableWidthUnitKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DXW.TableWidthType openXmlElement, DMW.TableWidthUnitKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues, DMW.TableWidthUnitKind>(value);
  }
  
  public static DMW.TableWidthType? CreateModelElement(DXW.TableWidthType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableWidthType();
      value.Width = GetWidth(openXmlElement);
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableWidthType? value)
    where OpenXmlElementType: DXW.TableWidthType, new()
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
