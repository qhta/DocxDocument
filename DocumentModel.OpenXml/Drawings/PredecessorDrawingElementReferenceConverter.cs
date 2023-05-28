namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the PredecessorDrawingElementReference Class.
/// </summary>
public static class PredecessorDrawingElementReferenceConverter
{
  /// <summary>
  /// pred, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetPred(DXO16D.PredecessorDrawingElementReference openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Pred);
  }
  
  private static bool CmpPred(DXO16D.PredecessorDrawingElementReference openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Pred, value, diffs, objName, "Pred");
  }
  
  private static void SetPred(DXO16D.PredecessorDrawingElementReference openXmlElement, String? value)
  {
    openXmlElement.Pred = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMD.PredecessorDrawingElementReference? CreateModelElement(DXO16D.PredecessorDrawingElementReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.PredecessorDrawingElementReference();
      value.Pred = GetPred(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16D.PredecessorDrawingElementReference? openXmlElement, DMD.PredecessorDrawingElementReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPred(openXmlElement, value.Pred, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.PredecessorDrawingElementReference value)
    where OpenXmlElementType: DXO16D.PredecessorDrawingElementReference, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16D.PredecessorDrawingElementReference openXmlElement, DMD.PredecessorDrawingElementReference value)
  {
    SetPred(openXmlElement, value?.Pred);
  }
}
