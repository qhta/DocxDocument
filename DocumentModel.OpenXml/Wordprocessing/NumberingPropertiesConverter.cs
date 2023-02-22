namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the NumberingProperties Class.
/// </summary>
public static class NumberingPropertiesConverter
{
  /// <summary>
  /// Numbering Level Reference.
  /// </summary>
  private static Int32? GetNumberingLevelReference(DXW.NumberingProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.NumberingLevelReference>()?.Val);
  }
  
  private static bool CmpNumberingLevelReference(DXW.NumberingProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.NumberingLevelReference>()?.Val, value, diffs, objName, "NumberingLevelReference");
  }
  
  private static void SetNumberingLevelReference(DXW.NumberingProperties openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.NumberingLevelReference,System.Int32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Numbering Definition Instance Reference.
  /// </summary>
  private static Int32? GetNumberingId(DXW.NumberingProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.NumberingId>()?.Val);
  }
  
  private static bool CmpNumberingId(DXW.NumberingProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.NumberingId>()?.Val, value, diffs, objName, "NumberingId");
  }
  
  private static void SetNumberingId(DXW.NumberingProperties openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.NumberingId,System.Int32>(openXmlElement, value);
  }
  
  /// <summary>
  /// Previous Paragraph Numbering Properties.
  /// </summary>
  private static DMW.NumberingChange? GetNumberingChange(DXW.NumberingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.NumberingChange>();
    if (element != null)
      return DMXW.NumberingChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingChange(DXW.NumberingProperties openXmlElement, DMW.NumberingChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.NumberingChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.NumberingChange>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberingChange(DXW.NumberingProperties openXmlElement, DMW.NumberingChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NumberingChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.NumberingChangeConverter.CreateOpenXmlElement<DXW.NumberingChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Inserted Numbering Properties.
  /// </summary>
  private static DMW.TrackChangeType? GetInserted(DXW.NumberingProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Inserted>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpInserted(DXW.NumberingProperties openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Inserted>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetInserted(DXW.NumberingProperties openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Inserted>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.Inserted>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.NumberingProperties? CreateModelElement(DXW.NumberingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.NumberingProperties();
      value.NumberingLevelReference = GetNumberingLevelReference(openXmlElement);
      value.NumberingId = GetNumberingId(openXmlElement);
      value.NumberingChange = GetNumberingChange(openXmlElement);
      value.Inserted = GetInserted(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.NumberingProperties? openXmlElement, DMW.NumberingProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNumberingLevelReference(openXmlElement, value.NumberingLevelReference, diffs, objName))
        ok = false;
      if (!CmpNumberingId(openXmlElement, value.NumberingId, diffs, objName))
        ok = false;
      if (!CmpNumberingChange(openXmlElement, value.NumberingChange, diffs, objName))
        ok = false;
      if (!CmpInserted(openXmlElement, value.Inserted, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.NumberingProperties value)
    where OpenXmlElementType: DXW.NumberingProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.NumberingProperties openXmlElement, DMW.NumberingProperties value)
  {
    SetNumberingLevelReference(openXmlElement, value?.NumberingLevelReference);
    SetNumberingId(openXmlElement, value?.NumberingId);
    SetNumberingChange(openXmlElement, value?.NumberingChange);
    SetInserted(openXmlElement, value?.Inserted);
    }
  }
