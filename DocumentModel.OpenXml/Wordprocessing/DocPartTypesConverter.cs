namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Entry Types converter from/to OpenXml.
///</summary>
public static class DocPartTypesConverter
{
  /// <summary>
  /// Entry Is Of All Types
  /// </summary>
  private static Boolean? GetAll(DXW.DocPartTypes openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.All);
  }
  
  private static bool CmpAll(DXW.DocPartTypes openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.All, value, diffs, objName, "All");
  }
  
  private static void SetAll(DXW.DocPartTypes openXmlElement, Boolean? value)
  {
    openXmlElement.All = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  private static DMW.DocPartKind? GetDocPartType(DXW.DocPartTypes openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocPartValues, DMW.DocPartKind>(openXmlElement.GetFirstChild<DXW.DocPartType>()?.Val?.Value);
  }
  
  private static bool CmpDocPartType(DXW.DocPartTypes openXmlElement, DMW.DocPartKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.DocPartValues, DMW.DocPartKind>(openXmlElement.GetFirstChild<DXW.DocPartType>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetDocPartType(DXW.DocPartTypes openXmlElement, DMW.DocPartKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartType>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocPartValues, DMW.DocPartKind>(itemElement, (DMW.DocPartKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.DocPartType, DocumentFormat.OpenXml.Wordprocessing.DocPartValues, DMW.DocPartKind>((DMW.DocPartKind)value));
  }
  
  public static DMW.DocPartTypes? CreateModelElement(DXW.DocPartTypes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DocPartTypes();
      value.All = GetAll(openXmlElement);
      value.DocPartType = GetDocPartType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.DocPartTypes? openXmlElement, DMW.DocPartTypes? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAll(openXmlElement, value.All, diffs, objName))
        ok = false;
      if (!CmpDocPartType(openXmlElement, value.DocPartType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DocPartTypes value)
    where OpenXmlElementType: DXW.DocPartTypes, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.DocPartTypes openXmlElement, DMW.DocPartTypes value)
  {
    SetAll(openXmlElement, value?.All);
    SetDocPartType(openXmlElement, value?.DocPartType);
  }
}
