using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using TableWidthDxaNilType = DocumentFormat.OpenXml.Wordprocessing.TableWidthDxaNilType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the TableWidthDxaNilType Class.
/// </summary>
public static class TableWidthDxaNilTypeConverter
{
  /// <summary>
  ///   w
  /// </summary>
  public static Int16? GetWidth(TableWidthDxaNilType? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }

  public static void SetWidth(TableWidthDxaNilType? openXmlElement, Int16? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }

  /// <summary>
  ///   type
  /// </summary>
  public static TableWidthKind? GetType(TableWidthDxaNilType? openXmlElement)
  {
    return EnumValueConverter.GetValue<TableWidthValues, TableWidthKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(TableWidthDxaNilType? openXmlElement, TableWidthKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<TableWidthValues, TableWidthKind>(value);
  }

  public static DocumentModel.Wordprocessing.TableWidthDxaNilType? CreateModelElement(TableWidthDxaNilType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableWidthDxaNilType();
      value.Width = GetWidth(openXmlElement);
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableWidthDxaNilType? value)
    where OpenXmlElementType : TableWidthDxaNilType, new()
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