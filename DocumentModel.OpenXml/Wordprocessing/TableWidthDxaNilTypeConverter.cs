namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableWidthDxaNilType Class.
/// </summary>
public static class TableWidthDxaNilTypeConverter
{
  /// <summary>
  /// w
  /// </summary>
  private static Int16? GetWidth(DXW.TableWidthDxaNilType openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static void SetWidth(DXW.TableWidthDxaNilType openXmlElement, Int16? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// type
  /// </summary>
  private static DMW.TableWidthKind? GetType(DXW.TableWidthDxaNilType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthValues, DMW.TableWidthKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DXW.TableWidthDxaNilType openXmlElement, DMW.TableWidthKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableWidthValues, DMW.TableWidthKind>(value);
  }
  
  public static DMW.TableWidthDxaNilType? CreateModelElement(DXW.TableWidthDxaNilType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableWidthDxaNilType();
      value.Width = GetWidth(openXmlElement);
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableWidthDxaNilType? value)
    where OpenXmlElementType: DXW.TableWidthDxaNilType, new()
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
