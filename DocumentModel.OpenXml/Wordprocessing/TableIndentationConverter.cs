using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using TableIndentation = DocumentFormat.OpenXml.Wordprocessing.TableIndentation;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the TableIndentation Class.
/// </summary>
public static class TableIndentationConverter
{
  /// <summary>
  ///   w
  /// </summary>
  public static Int32? GetWidth(TableIndentation? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }

  public static void SetWidth(TableIndentation? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }

  /// <summary>
  ///   type
  /// </summary>
  public static TableWidthUnitKind? GetType(TableIndentation? openXmlElement)
  {
    return EnumValueConverter.GetValue<TableWidthUnitValues, TableWidthUnitKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(TableIndentation? openXmlElement, TableWidthUnitKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<TableWidthUnitValues, TableWidthUnitKind>(value);
  }

  public static DocumentModel.Wordprocessing.TableIndentation? CreateModelElement(TableIndentation? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableIndentation();
      value.Width = GetWidth(openXmlElement);
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableIndentation? value)
    where OpenXmlElementType : TableIndentation, new()
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