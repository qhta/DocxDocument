using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using TableWidthType = DocumentFormat.OpenXml.Wordprocessing.TableWidthType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the TableWidthType Class.
/// </summary>
public static class TableWidthTypeConverter
{
  /// <summary>
  ///   Table Width Value
  /// </summary>
  public static String? GetWidth(TableWidthType? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }

  public static void SetWidth(TableWidthType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Width = new StringValue { Value = value };
      else
        openXmlElement.Width = null;
  }

  /// <summary>
  ///   Table Width Type
  /// </summary>
  public static TableWidthUnitKind? GetType(TableWidthType? openXmlElement)
  {
    return EnumValueConverter.GetValue<TableWidthUnitValues, TableWidthUnitKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(TableWidthType? openXmlElement, TableWidthUnitKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<TableWidthUnitValues, TableWidthUnitKind>(value);
  }

  public static DocumentModel.Wordprocessing.TableWidthType? CreateModelElement(TableWidthType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableWidthType();
      value.Width = GetWidth(openXmlElement);
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableWidthType? value)
    where OpenXmlElementType : TableWidthType, new()
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