namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TableLayout Class.
/// </summary>
public static class TableLayoutConverter
{
  /// <summary>
  /// Table Layout Setting
  /// </summary>
  private static DMW.TableLayoutKind? GetType(DXW.TableLayout openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableLayoutValues, DMW.TableLayoutKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DXW.TableLayout openXmlElement, DMW.TableLayoutKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableLayoutValues, DMW.TableLayoutKind>(value);
  }
  
  public static DMW.TableLayout? CreateModelElement(DXW.TableLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableLayout();
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableLayout? value)
    where OpenXmlElementType: DXW.TableLayout, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      return openXmlElement;
    }
    return default;
  }
}
