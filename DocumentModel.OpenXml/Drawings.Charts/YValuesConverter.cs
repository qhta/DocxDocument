namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the YValues Class.
/// </summary>
public static class YValuesConverter
{
  private static DMDC.NumberReference? GetNumberReference(DXDC.YValues openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.NumberReference>();
    if (element != null)
      return DMXDC.NumberReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberReference(DXDC.YValues openXmlElement, DMDC.NumberReference? value, DiffList? diffs, string? objName)
  {
    return DMXDC.NumberReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.NumberReference>(), value, diffs, objName);
  }
  
  private static void SetNumberReference(DXDC.YValues openXmlElement, DMDC.NumberReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.NumberReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.NumberReferenceConverter.CreateOpenXmlElement<DXDC.NumberReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDC.NumberLiteral? GetNumberLiteral(DXDC.YValues openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.NumberLiteral>();
    if (element != null)
      return DMXDC.NumberLiteralConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberLiteral(DXDC.YValues openXmlElement, DMDC.NumberLiteral? value, DiffList? diffs, string? objName)
  {
    return DMXDC.NumberLiteralConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.NumberLiteral>(), value, diffs, objName);
  }
  
  private static void SetNumberLiteral(DXDC.YValues openXmlElement, DMDC.NumberLiteral? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.NumberLiteral>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.NumberLiteralConverter.CreateOpenXmlElement<DXDC.NumberLiteral>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.YValues? CreateModelElement(DXDC.YValues? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.YValues();
      value.NumberReference = GetNumberReference(openXmlElement);
      value.NumberLiteral = GetNumberLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.YValues? openXmlElement, DMDC.YValues? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNumberReference(openXmlElement, value.NumberReference, diffs, objName))
        ok = false;
      if (!CmpNumberLiteral(openXmlElement, value.NumberLiteral, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.YValues value)
    where OpenXmlElementType: DXDC.YValues, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.YValues openXmlElement, DMDC.YValues value)
  {
    SetNumberReference(openXmlElement, value?.NumberReference);
    SetNumberLiteral(openXmlElement, value?.NumberLiteral);
  }
}
