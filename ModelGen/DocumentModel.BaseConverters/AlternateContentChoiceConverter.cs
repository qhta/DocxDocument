using DocumentModel;

namespace DocumentModel.OpenXml;

/// <summary>
/// AlternateContentChoice element converter
/// </summary>
public static class AlternateContentChoiceConverter
{
  public static AlternateContentChoice? CreateModelElement(DX.AlternateContentChoice? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var result = ElementCollectionConverter<ModelElement>.CreateModelElement<AlternateContentChoice>(openXmlElement);
      if (result != null)
        result.Requires = StringValueConverter.GetValue(openXmlElement.Requires);
      return result;
    }
    return null;
  }

  public static bool CompareModelElement(DX.AlternateContentChoice? openXmlElement, AlternateContentChoice? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = ElementCollectionConverter<ModelElement>.CompareModelElement(openXmlElement, value, diffs, objName, propName);
      if (!StringValueConverter.CmpValue(openXmlElement.Requires, value.Requires, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static DX.AlternateContentChoice CreateOpenXmlElement(AlternateContentChoice value)
  {
    var openXmlElement = new DX.AlternateContentChoice();
    ElementCollectionConverter<ModelElement>.UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DX.AlternateContentChoice openXmlElement, AlternateContentChoice value)
  {
    ElementCollectionConverter<ModelElement>.UpdateOpenXmlElement(openXmlElement, value);
    if (value.Requires != null)
      openXmlElement.Requires = StringValueConverter.CreateStringValue(value.Requires);
  }
}
