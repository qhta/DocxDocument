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
    return openXmlElement?.Pred?.Value;
  }
  
  private static bool CmpPred(DXO2016Draw.PredecessorDrawingElementReference openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Pred?.Value == value;
  }
  
  private static void SetPred(DXO2016Draw.PredecessorDrawingElementReference openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Pred = new StringValue { Value = value };
    else
      openXmlElement.Pred = null;
  }
  
  public static DMDraws.PredecessorDrawingElementReference? CreateModelElement(DXO2016Draw.PredecessorDrawingElementReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.PredecessorDrawingElementReference();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.PredecessorDrawingElementReference? value)
    where OpenXmlElementType: DXO2016Draw.PredecessorDrawingElementReference, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPred(openXmlElement, value?.Pred);
      return openXmlElement;
    }
    return default;
  }
}
