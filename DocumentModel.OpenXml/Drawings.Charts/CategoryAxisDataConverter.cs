namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the CategoryAxisData Class.
/// </summary>
public static class CategoryAxisDataConverter
{
  private static DMDC.MultiLevelStringReference? GetMultiLevelStringReference(DXDC.CategoryAxisData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.MultiLevelStringReference>();
    if (element != null)
      return DMXDC.MultiLevelStringReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMultiLevelStringReference(DXDC.CategoryAxisData openXmlElement, DMDC.MultiLevelStringReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.MultiLevelStringReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.MultiLevelStringReference>(), value, diffs, objName, propName);
  }
  
  private static void SetMultiLevelStringReference(DXDC.CategoryAxisData openXmlElement, DMDC.MultiLevelStringReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.MultiLevelStringReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.MultiLevelStringReferenceConverter.CreateOpenXmlElement<DXDC.MultiLevelStringReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.NumberReference? GetNumberReference(DXDC.CategoryAxisData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.NumberReference>();
    if (element != null)
      return DMXDC.NumberReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberReference(DXDC.CategoryAxisData openXmlElement, DMDC.NumberReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.NumberReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.NumberReference>(), value, diffs, objName, propName);
  }
  
  private static void SetNumberReference(DXDC.CategoryAxisData openXmlElement, DMDC.NumberReference? value)
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
  
  private static DMDC.NumberLiteral? GetNumberLiteral(DXDC.CategoryAxisData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.NumberLiteral>();
    if (element != null)
      return DMXDC.NumberLiteralConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberLiteral(DXDC.CategoryAxisData openXmlElement, DMDC.NumberLiteral? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.NumberLiteralConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.NumberLiteral>(), value, diffs, objName, propName);
  }
  
  private static void SetNumberLiteral(DXDC.CategoryAxisData openXmlElement, DMDC.NumberLiteral? value)
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
  
  private static DMDC.StringReference? GetStringReference(DXDC.CategoryAxisData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.StringReference>();
    if (element != null)
      return DMXDC.StringReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringReference(DXDC.CategoryAxisData openXmlElement, DMDC.StringReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.StringReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.StringReference>(), value, diffs, objName, propName);
  }
  
  private static void SetStringReference(DXDC.CategoryAxisData openXmlElement, DMDC.StringReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.StringReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.StringReferenceConverter.CreateOpenXmlElement<DXDC.StringReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.StringLiteral? GetStringLiteral(DXDC.CategoryAxisData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.StringLiteral>();
    if (element != null)
      return DMXDC.StringLiteralConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringLiteral(DXDC.CategoryAxisData openXmlElement, DMDC.StringLiteral? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.StringLiteralConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.StringLiteral>(), value, diffs, objName, propName);
  }
  
  private static void SetStringLiteral(DXDC.CategoryAxisData openXmlElement, DMDC.StringLiteral? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.StringLiteral>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.StringLiteralConverter.CreateOpenXmlElement<DXDC.StringLiteral>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.CategoryAxisData? CreateModelElement(DXDC.CategoryAxisData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.CategoryAxisData();
      value.MultiLevelStringReference = GetMultiLevelStringReference(openXmlElement);
      value.NumberReference = GetNumberReference(openXmlElement);
      value.NumberLiteral = GetNumberLiteral(openXmlElement);
      value.StringReference = GetStringReference(openXmlElement);
      value.StringLiteral = GetStringLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.CategoryAxisData? openXmlElement, DMDC.CategoryAxisData? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMultiLevelStringReference(openXmlElement, value.MultiLevelStringReference, diffs, objName, propName))
        ok = false;
      if (!CmpNumberReference(openXmlElement, value.NumberReference, diffs, objName, propName))
        ok = false;
      if (!CmpNumberLiteral(openXmlElement, value.NumberLiteral, diffs, objName, propName))
        ok = false;
      if (!CmpStringReference(openXmlElement, value.StringReference, diffs, objName, propName))
        ok = false;
      if (!CmpStringLiteral(openXmlElement, value.StringLiteral, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.CategoryAxisData value)
    where OpenXmlElementType: DXDC.CategoryAxisData, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.CategoryAxisData openXmlElement, DMDC.CategoryAxisData value)
  {
    SetMultiLevelStringReference(openXmlElement, value?.MultiLevelStringReference);
    SetNumberReference(openXmlElement, value?.NumberReference);
    SetNumberLiteral(openXmlElement, value?.NumberLiteral);
    SetStringReference(openXmlElement, value?.StringReference);
    SetStringLiteral(openXmlElement, value?.StringLiteral);
  }
}
