namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the XValues Class.
/// </summary>
public static class XValuesConverter
{
  private static DMDC.MultiLevelStringReference? GetMultiLevelStringReference(DXDC.XValues openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.MultiLevelStringReference>();
    if (element != null)
      return DMXDC.MultiLevelStringReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMultiLevelStringReference(DXDC.XValues openXmlElement, DMDC.MultiLevelStringReference? value, DiffList? diffs, string? objName)
  {
    return DMXDC.MultiLevelStringReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.MultiLevelStringReference>(), value, diffs, objName);
  }
  
  private static void SetMultiLevelStringReference(DXDC.XValues openXmlElement, DMDC.MultiLevelStringReference? value)
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
  
  private static DMDC.NumberReference? GetNumberReference(DXDC.XValues openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.NumberReference>();
    if (element != null)
      return DMXDC.NumberReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberReference(DXDC.XValues openXmlElement, DMDC.NumberReference? value, DiffList? diffs, string? objName)
  {
    return DMXDC.NumberReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.NumberReference>(), value, diffs, objName);
  }
  
  private static void SetNumberReference(DXDC.XValues openXmlElement, DMDC.NumberReference? value)
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
  
  private static DMDC.NumberLiteral? GetNumberLiteral(DXDC.XValues openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.NumberLiteral>();
    if (element != null)
      return DMXDC.NumberLiteralConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberLiteral(DXDC.XValues openXmlElement, DMDC.NumberLiteral? value, DiffList? diffs, string? objName)
  {
    return DMXDC.NumberLiteralConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.NumberLiteral>(), value, diffs, objName);
  }
  
  private static void SetNumberLiteral(DXDC.XValues openXmlElement, DMDC.NumberLiteral? value)
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
  
  private static DMDC.StringReference? GetStringReference(DXDC.XValues openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.StringReference>();
    if (element != null)
      return DMXDC.StringReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringReference(DXDC.XValues openXmlElement, DMDC.StringReference? value, DiffList? diffs, string? objName)
  {
    return DMXDC.StringReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.StringReference>(), value, diffs, objName);
  }
  
  private static void SetStringReference(DXDC.XValues openXmlElement, DMDC.StringReference? value)
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
  
  private static DMDC.StringLiteral? GetStringLiteral(DXDC.XValues openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.StringLiteral>();
    if (element != null)
      return DMXDC.StringLiteralConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringLiteral(DXDC.XValues openXmlElement, DMDC.StringLiteral? value, DiffList? diffs, string? objName)
  {
    return DMXDC.StringLiteralConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.StringLiteral>(), value, diffs, objName);
  }
  
  private static void SetStringLiteral(DXDC.XValues openXmlElement, DMDC.StringLiteral? value)
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
  
  public static DocumentModel.Drawings.Charts.XValues? CreateModelElement(DXDC.XValues? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.XValues();
      value.MultiLevelStringReference = GetMultiLevelStringReference(openXmlElement);
      value.NumberReference = GetNumberReference(openXmlElement);
      value.NumberLiteral = GetNumberLiteral(openXmlElement);
      value.StringReference = GetStringReference(openXmlElement);
      value.StringLiteral = GetStringLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.XValues? openXmlElement, DMDC.XValues? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMultiLevelStringReference(openXmlElement, value.MultiLevelStringReference, diffs, objName))
        ok = false;
      if (!CmpNumberReference(openXmlElement, value.NumberReference, diffs, objName))
        ok = false;
      if (!CmpNumberLiteral(openXmlElement, value.NumberLiteral, diffs, objName))
        ok = false;
      if (!CmpStringReference(openXmlElement, value.StringReference, diffs, objName))
        ok = false;
      if (!CmpStringLiteral(openXmlElement, value.StringLiteral, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.XValues value)
    where OpenXmlElementType: DXDC.XValues, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.XValues openXmlElement, DMDC.XValues value)
  {
    SetMultiLevelStringReference(openXmlElement, value?.MultiLevelStringReference);
    SetNumberReference(openXmlElement, value?.NumberReference);
    SetNumberLiteral(openXmlElement, value?.NumberLiteral);
    SetStringReference(openXmlElement, value?.StringReference);
    SetStringLiteral(openXmlElement, value?.StringLiteral);
  }
}
