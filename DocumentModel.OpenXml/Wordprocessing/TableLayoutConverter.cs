using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using TableLayout = DocumentFormat.OpenXml.Wordprocessing.TableLayout;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the TableLayout Class.
/// </summary>
public static class TableLayoutConverter
{
  /// <summary>
  ///   Table Layout Setting
  /// </summary>
  public static TableLayoutKind? GetType(TableLayout? openXmlElement)
  {
    return EnumValueConverter.GetValue<TableLayoutValues, TableLayoutKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(TableLayout? openXmlElement, TableLayoutKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<TableLayoutValues, TableLayoutKind>(value);
  }

  public static DocumentModel.Wordprocessing.TableLayout? CreateModelElement(TableLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableLayout();
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableLayout? value)
    where OpenXmlElementType : TableLayout, new()
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