namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Entry Types.
/// </summary>
public static class DocPartTypesConverter
{
  /// <summary>
  /// Entry Is Of All Types
  /// </summary>
  private static Boolean? GetAll(DXW.DocPartTypes openXmlElement)
  {
    return openXmlElement?.All?.Value;
  }
  
  private static bool CmpAll(DXW.DocPartTypes openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.All?.Value == value;
  }
  
  private static void SetAll(DXW.DocPartTypes openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.All = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.All = null;
  }
  
  private static DMW.DocPartKind? GetDocPartType(DXW.DocPartTypes openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocPartValues, DMW.DocPartKind>(openXmlElement.GetFirstChild<DXW.DocPartType>()?.Val?.Value);
  }
  
  private static bool CmpDocPartType(DXW.DocPartTypes openXmlElement, DMW.DocPartKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.DocPartValues, DMW.DocPartKind>(openXmlElement.GetFirstChild<DXW.DocPartType>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDocPartType(DXW.DocPartTypes openXmlElement, DMW.DocPartKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.DocPartType, DocumentFormat.OpenXml.Wordprocessing.DocPartValues, DMW.DocPartKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DocPartTypes? value)
    where OpenXmlElementType: DXW.DocPartTypes, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAll(openXmlElement, value?.All);
      SetDocPartType(openXmlElement, value?.DocPartType);
      return openXmlElement;
    }
    return default;
  }
}
