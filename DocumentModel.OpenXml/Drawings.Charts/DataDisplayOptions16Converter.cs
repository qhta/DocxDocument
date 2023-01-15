using DocumentFormat.OpenXml.Office2019.Drawing.Chart;
using DataDisplayOptions16 = DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the DataDisplayOptions16 Class.
/// </summary>
public static class DataDisplayOptions16Converter
{
  /// <summary>
  ///   BooleanFalse.
  /// </summary>
  public static Boolean? GetBooleanFalse(DataDisplayOptions16? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BooleanFalse>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBooleanFalse(DataDisplayOptions16? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<BooleanFalse>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new BooleanFalse();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.DataDisplayOptions16? CreateModelElement(DataDisplayOptions16? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DataDisplayOptions16();
      value.BooleanFalse = GetBooleanFalse(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DataDisplayOptions16? value)
    where OpenXmlElementType : DataDisplayOptions16, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBooleanFalse(openXmlElement, value?.BooleanFalse);
      return openXmlElement;
    }
    return default;
  }
}