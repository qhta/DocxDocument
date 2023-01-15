using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using TableRowHeight = DocumentFormat.OpenXml.Wordprocessing.TableRowHeight;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the TableRowHeight Class.
/// </summary>
public static class TableRowHeightConverter
{
  /// <summary>
  ///   Table Row Height
  /// </summary>
  public static UInt32? GetVal(TableRowHeight? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(TableRowHeight? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = value;
  }

  /// <summary>
  ///   Table Row Height Type
  /// </summary>
  public static HeightRuleKind? GetHeightType(TableRowHeight? openXmlElement)
  {
    return EnumValueConverter.GetValue<HeightRuleValues, HeightRuleKind>(openXmlElement?.HeightType?.Value);
  }

  public static void SetHeightType(TableRowHeight? openXmlElement, HeightRuleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HeightType = EnumValueConverter.CreateEnumValue<HeightRuleValues, HeightRuleKind>(value);
  }

  public static DocumentModel.Wordprocessing.TableRowHeight? CreateModelElement(TableRowHeight? openXmlElement)
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
    where OpenXmlElementType : TableRowHeight, new()
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