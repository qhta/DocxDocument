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

  public static VectorVariant? GetHeadingPairs(DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs? openXmlElement)
  {
    if (openXmlElement?.VTVector == null) return null;
    var result = VTVectorConverter.CreateModelElement(openXmlElement?.VTVector);
    return result;
  }

  public static void SetHeadingPairs(DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs? openXmlElement,VectorVariant? value)
  {
    if (openXmlElement != null && value != null)
    {
      var vector = new VectorVariant();
      foreach (var item in value)
      {
        vector.Add(item);
      }
      openXmlElement.VTVector = VTVectorConverter.CreateOpenXmlElement(vector);
    }
  }

  public static VectorVariant? CreateModelElement(DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = GetHeadingPairs(openXmlElement);
      return value;
    }
    return null;
  }

  public static DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs? CreateOpenXmlElement(VectorVariant? value)
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