namespace DocumentModel.OpenXml.Properties;

/// <summary>
///   Part Titles.
/// </summary>
public static class TitlesOfPartsConverter
{
  public static VectorVariant? GetVTVector(DXEP.TitlesOfParts? openXmlElement)
  {
    return VTVectorConverter.CreateModelElement(openXmlElement?.VTVector);
  }

  public static void SetVTVector(DXEP.TitlesOfParts? openXmlElement, VectorVariant? value)
  {
    if (openXmlElement != null)
      openXmlElement.VTVector = VTVectorConverter.CreateOpenXmlElement(value);
  }

  public static StringList? GetStrings(DXEP.TitlesOfParts? openXmlElement)
  {
    return VTVectorConverter.GetStringList(openXmlElement?.VTVector);
  }

  public static void SetStrings(DXEP.TitlesOfParts? openXmlElement, StringList? value)
  {
    if (openXmlElement != null && value != null)
    {
      var vector = new VectorVariant();
      vector.BaseType = VariantType.Lpstr;
      foreach (var item in value)
      {
        vector.Add(new Variant(item));
      }
      openXmlElement.VTVector = VTVectorConverter.CreateOpenXmlElement(vector);
    }
  }

  public static StringList? CreateModelElement(DXEP.TitlesOfParts? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = GetStrings(openXmlElement);
      return value;
    }
    return null;
  }

  public static DXEP.TitlesOfParts? CreateOpenXmlElement(VectorVariant? value)
  {
    if (value != null)
    {
      var openXmlElement = new DXEP.TitlesOfParts();
      SetVTVector(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }

  public static DXEP.TitlesOfParts? CreateOpenXmlElement(StringList? value)
  {
    if (value != null)
    {
      var openXmlElement = new DXEP.TitlesOfParts();
      SetStrings(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }
}