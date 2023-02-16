namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FullReference Class.
/// </summary>
public static class FullReferenceConverter
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  private static String? GetSequenceOfReferences(DXO2013DrawChart.FullReference openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO2013DrawChart.SequenceOfReferences>()?.Text;
  }
  
  private static bool CmpSequenceOfReferences(DXO2013DrawChart.FullReference openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO2013DrawChart.SequenceOfReferences>()?.Text == value;
  }
  
  private static void SetSequenceOfReferences(DXO2013DrawChart.FullReference openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.SequenceOfReferences>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2013DrawChart.SequenceOfReferences { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.FullReference? CreateModelElement(DXO2013DrawChart.FullReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FullReference();
      value.SequenceOfReferences = GetSequenceOfReferences(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChart.FullReference? openXmlElement, DMDrawsCharts.FullReference? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSequenceOfReferences(openXmlElement, value.SequenceOfReferences, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.FullReference? value)
    where OpenXmlElementType: DXO2013DrawChart.FullReference, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSequenceOfReferences(openXmlElement, value?.SequenceOfReferences);
      return openXmlElement;
    }
    return default;
  }
}
