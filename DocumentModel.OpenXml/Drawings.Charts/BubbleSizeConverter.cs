namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BubbleSize Class.
/// </summary>
public static class BubbleSizeConverter
{
  private static DMDC.NumberReference? GetNumberReference(DXDC.BubbleSize openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.NumberReference>();
    if (element != null)
      return DMXDC.NumberReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberReference(DXDC.BubbleSize openXmlElement, DMDC.NumberReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.NumberReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.NumberReference>(), value, diffs, objName, propName);
  }
  
  private static void SetNumberReference(DXDC.BubbleSize openXmlElement, DMDC.NumberReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.NumberReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.NumberReferenceConverter.CreateOpenXmlElement<DXDC.NumberReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.NumberLiteral? GetNumberLiteral(DXDC.BubbleSize openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.NumberLiteral>();
    if (element != null)
      return DMXDC.NumberLiteralConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberLiteral(DXDC.BubbleSize openXmlElement, DMDC.NumberLiteral? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.NumberLiteralConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.NumberLiteral>(), value, diffs, objName, propName);
  }
  
  private static void SetNumberLiteral(DXDC.BubbleSize openXmlElement, DMDC.NumberLiteral? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.NumberLiteral>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.NumberLiteralConverter.CreateOpenXmlElement<DXDC.NumberLiteral>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.BubbleSize? CreateModelElement(DXDC.BubbleSize? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.BubbleSize();
      value.NumberReference = GetNumberReference(openXmlElement);
      value.NumberLiteral = GetNumberLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.BubbleSize? openXmlElement, DMDC.BubbleSize? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNumberReference(openXmlElement, value.NumberReference, diffs, objName, propName))
        ok = false;
      if (!CmpNumberLiteral(openXmlElement, value.NumberLiteral, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.BubbleSize value)
    where OpenXmlElementType: DXDC.BubbleSize, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.BubbleSize openXmlElement, DMDC.BubbleSize value)
  {
    SetNumberReference(openXmlElement, value?.NumberReference);
    SetNumberLiteral(openXmlElement, value?.NumberLiteral);
  }
}
