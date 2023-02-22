namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the PredecessorDrawingElementReference Class.
/// </summary>
public static class PredecessorDrawingElementReferenceConverter
{
  /// <summary>
  /// pred, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetPred(DXO2016Draw.PredecessorDrawingElementReference openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Pred);
  }
  
  private static bool CmpPred(DXO2016Draw.PredecessorDrawingElementReference openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Pred, value, diffs, objName, "Pred");
  }
  
  private static void SetPred(DXO2016Draw.PredecessorDrawingElementReference openXmlElement, String? value)
  {
    openXmlElement.Pred = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.PredecessorDrawingElementReference? CreateModelElement(DXO2016Draw.PredecessorDrawingElementReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PredecessorDrawingElementReference();
      value.Pred = GetPred(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016Draw.PredecessorDrawingElementReference? openXmlElement, DMDraws.PredecessorDrawingElementReference? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPred(openXmlElement, value.Pred, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.PredecessorDrawingElementReference value)
    where OpenXmlElementType: DXO2016Draw.PredecessorDrawingElementReference, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016Draw.PredecessorDrawingElementReference openXmlElement, DMDraws.PredecessorDrawingElementReference value)
  {
    SetPred(openXmlElement, value?.Pred);
  }
}
