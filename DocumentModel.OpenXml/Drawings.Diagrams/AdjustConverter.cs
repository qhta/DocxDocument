using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Shape Adjust.
/// </summary>
public static class AdjustConverter
{
  /// <summary>
  ///   Adjust Handle Index
  /// </summary>
  public static UInt32? GetIndex(Adjust? openXmlElement)
  {
    return openXmlElement?.Index?.Value;
  }

  public static void SetIndex(Adjust? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Index = value;
  }

  /// <summary>
  ///   Value
  /// </summary>
  public static Double? GetVal(Adjust? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(Adjust? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Val = value;
  }

  public static DocumentModel.Drawings.Diagrams.Adjust? CreateModelElement(Adjust? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Adjust();
      value.Index = GetIndex(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Adjust? value)
    where OpenXmlElementType : Adjust, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}