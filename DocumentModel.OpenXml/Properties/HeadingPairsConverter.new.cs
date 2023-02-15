namespace DocumentModel.OpenXml.Properties;

/// <summary>
///   Heading Pairs.
/// </summary>
public static class HeadingPairsConverter
{
  public static VectorVariant? GetVTVector(DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs? openXmlElement)
  {
    return VTVectorConverter.CreateModelElement(openXmlElement?.VTVector);
  }

  public static void SetVTVector(DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs? openXmlElement, VectorVariant? value)
  {
    if (openXmlElement != null)
      openXmlElement.VTVector = VTVectorConverter.CreateOpenXmlElement(value);
  }

  public static DMProps.HeadingPairs? GetHeadingPairs(DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs? openXmlElement)
  {
    if (openXmlElement?.VTVector == null) return null;
    var vector = VTVectorConverter.CreateModelElement(openXmlElement?.VTVector);
    if (vector == null) return null;
    var result = new DMProps.HeadingPairs();
    for (var i = 0; i < vector.Count; i++)
    {
      var str = (string?)Convert.ChangeType(vector[i], typeof(string));
      i++;
      if (i >= vector.Count)
        break;
      var num = (int?)Convert.ChangeType(vector[i], typeof(int));
      if (str != null && num != null)
        result.Add(new StringNum { Str = str, Num = num });
    }
    return result;
  }

  public static void SetHeadingPairs(DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs? openXmlElement, DMProps.HeadingPairs? value)
  {
    if (openXmlElement != null && value != null)
    {
      var vector = new VectorVariant();
      foreach (var item in value)
      {
        vector.Add(item.Str);
        vector.Add(item.Num);
      }
      openXmlElement.VTVector = VTVectorConverter.CreateOpenXmlElement(vector);
    }
  }

  public static DMProps.HeadingPairs? CreateModelElement(DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = GetHeadingPairs(openXmlElement);
      return value;
    }
    return null;
  }

  public static DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs? CreateOpenXmlElement(DMProps.HeadingPairs? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs();
      SetHeadingPairs(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }
}