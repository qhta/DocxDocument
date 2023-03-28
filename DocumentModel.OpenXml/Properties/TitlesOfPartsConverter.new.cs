namespace DocumentModel.OpenXml.Properties;

/// <summary>
///   Part Titles converter from/to OpenXml.
///</summary>
public static class TitlesOfPartsConverter
{
  public static VectorVariant? GetVTVector(DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? openXmlElement)
  {
    return VTVectorConverter.CreateModelElement(openXmlElement?.VTVector);
  }

  public static void SetVTVector(DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? openXmlElement, VectorVariant? value)
  {
    if (openXmlElement != null)
      openXmlElement.VTVector = VTVectorConverter.CreateOpenXmlElement(value);
  }

  public static StringList? GetStrings(DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? openXmlElement)
  {
    return VTVectorConverter.GetStringList(openXmlElement?.VTVector);
  }

  public static void SetStrings(DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? openXmlElement, StringList? value)
  {
    if (openXmlElement != null)
      openXmlElement.VTVector = VTVectorConverter.CreateOpenXmlElement(value);
  }

  public static StringList? CreateModelElement(DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = GetStrings(openXmlElement);
      return value;
    }
    return null;
  }

  public static DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? CreateOpenXmlElement(VectorVariant? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts();
      SetVTVector(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }

  public static DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? CreateOpenXmlElement(StringList? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts();
      SetStrings(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }
}