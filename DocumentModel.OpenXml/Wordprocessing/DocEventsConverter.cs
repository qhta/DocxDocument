namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the DocEvents Class.
/// </summary>
public static class DocEventsConverter
{
  /// <summary>
  /// EventDocNewXsdString.
  /// </summary>
  private static String? GetEventDocNewXsdString(DXOW.DocEvents openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocNewXsdString>()?.Text;
  }
  
  private static bool CmpEventDocNewXsdString(DXOW.DocEvents openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocNewXsdString>()?.Text == value;
  }
  
  private static void SetEventDocNewXsdString(DXOW.DocEvents openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.EventDocNewXsdString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXOW.EventDocNewXsdString { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EventDocOpenXsdString.
  /// </summary>
  private static String? GetEventDocOpenXsdString(DXOW.DocEvents openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocOpenXsdString>()?.Text;
  }
  
  private static bool CmpEventDocOpenXsdString(DXOW.DocEvents openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocOpenXsdString>()?.Text == value;
  }
  
  private static void SetEventDocOpenXsdString(DXOW.DocEvents openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.EventDocOpenXsdString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXOW.EventDocOpenXsdString { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EventDocCloseXsdString.
  /// </summary>
  private static String? GetEventDocCloseXsdString(DXOW.DocEvents openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocCloseXsdString>()?.Text;
  }
  
  private static bool CmpEventDocCloseXsdString(DXOW.DocEvents openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocCloseXsdString>()?.Text == value;
  }
  
  private static void SetEventDocCloseXsdString(DXOW.DocEvents openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.EventDocCloseXsdString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXOW.EventDocCloseXsdString { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EventDocSyncXsdString.
  /// </summary>
  private static String? GetEventDocSyncXsdString(DXOW.DocEvents openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocSyncXsdString>()?.Text;
  }
  
  private static bool CmpEventDocSyncXsdString(DXOW.DocEvents openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocSyncXsdString>()?.Text == value;
  }
  
  private static void SetEventDocSyncXsdString(DXOW.DocEvents openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.EventDocSyncXsdString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXOW.EventDocSyncXsdString { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EventDocXmlAfterInsertXsdString.
  /// </summary>
  private static String? GetEventDocXmlAfterInsertXsdString(DXOW.DocEvents openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocXmlAfterInsertXsdString>()?.Text;
  }
  
  private static bool CmpEventDocXmlAfterInsertXsdString(DXOW.DocEvents openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocXmlAfterInsertXsdString>()?.Text == value;
  }
  
  private static void SetEventDocXmlAfterInsertXsdString(DXOW.DocEvents openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.EventDocXmlAfterInsertXsdString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXOW.EventDocXmlAfterInsertXsdString { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EventDocXmlBeforeDeleteXsdString.
  /// </summary>
  private static String? GetEventDocXmlBeforeDeleteXsdString(DXOW.DocEvents openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocXmlBeforeDeleteXsdString>()?.Text;
  }
  
  private static bool CmpEventDocXmlBeforeDeleteXsdString(DXOW.DocEvents openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocXmlBeforeDeleteXsdString>()?.Text == value;
  }
  
  private static void SetEventDocXmlBeforeDeleteXsdString(DXOW.DocEvents openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.EventDocXmlBeforeDeleteXsdString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXOW.EventDocXmlBeforeDeleteXsdString { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EventDocContentControlAfterInsertXsdString.
  /// </summary>
  private static String? GetEventDocContentControlAfterInsertXsdString(DXOW.DocEvents openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocContentControlAfterInsertXsdString>()?.Text;
  }
  
  private static bool CmpEventDocContentControlAfterInsertXsdString(DXOW.DocEvents openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocContentControlAfterInsertXsdString>()?.Text == value;
  }
  
  private static void SetEventDocContentControlAfterInsertXsdString(DXOW.DocEvents openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.EventDocContentControlAfterInsertXsdString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXOW.EventDocContentControlAfterInsertXsdString { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EventDocContentControlBeforeDeleteXsdString.
  /// </summary>
  private static String? GetEventDocContentControlBeforeDeleteXsdString(DXOW.DocEvents openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocContentControlBeforeDeleteXsdString>()?.Text;
  }
  
  private static bool CmpEventDocContentControlBeforeDeleteXsdString(DXOW.DocEvents openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocContentControlBeforeDeleteXsdString>()?.Text == value;
  }
  
  private static void SetEventDocContentControlBeforeDeleteXsdString(DXOW.DocEvents openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.EventDocContentControlBeforeDeleteXsdString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXOW.EventDocContentControlBeforeDeleteXsdString { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EventDocContentControlOnExistXsdString.
  /// </summary>
  private static String? GetEventDocContentControlOnExistXsdString(DXOW.DocEvents openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocContentControlOnExistXsdString>()?.Text;
  }
  
  private static bool CmpEventDocContentControlOnExistXsdString(DXOW.DocEvents openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocContentControlOnExistXsdString>()?.Text == value;
  }
  
  private static void SetEventDocContentControlOnExistXsdString(DXOW.DocEvents openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.EventDocContentControlOnExistXsdString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXOW.EventDocContentControlOnExistXsdString { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EventDocContentControlOnEnterXsdString.
  /// </summary>
  private static String? GetEventDocContentControlOnEnterXsdString(DXOW.DocEvents openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocContentControlOnEnterXsdString>()?.Text;
  }
  
  private static bool CmpEventDocContentControlOnEnterXsdString(DXOW.DocEvents openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocContentControlOnEnterXsdString>()?.Text == value;
  }
  
  private static void SetEventDocContentControlOnEnterXsdString(DXOW.DocEvents openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.EventDocContentControlOnEnterXsdString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXOW.EventDocContentControlOnEnterXsdString { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EventDocStoreUpdateXsdString.
  /// </summary>
  private static String? GetEventDocStoreUpdateXsdString(DXOW.DocEvents openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocStoreUpdateXsdString>()?.Text;
  }
  
  private static bool CmpEventDocStoreUpdateXsdString(DXOW.DocEvents openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocStoreUpdateXsdString>()?.Text == value;
  }
  
  private static void SetEventDocStoreUpdateXsdString(DXOW.DocEvents openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.EventDocStoreUpdateXsdString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXOW.EventDocStoreUpdateXsdString { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EventDocContentControlUpdateXsdString.
  /// </summary>
  private static String? GetEventDocContentControlUpdateXsdString(DXOW.DocEvents openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocContentControlUpdateXsdString>()?.Text;
  }
  
  private static bool CmpEventDocContentControlUpdateXsdString(DXOW.DocEvents openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocContentControlUpdateXsdString>()?.Text == value;
  }
  
  private static void SetEventDocContentControlUpdateXsdString(DXOW.DocEvents openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.EventDocContentControlUpdateXsdString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXOW.EventDocContentControlUpdateXsdString { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EventDocBuildingBlockAfterInsertXsdString.
  /// </summary>
  private static String? GetEventDocBuildingBlockAfterInsertXsdString(DXOW.DocEvents openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocBuildingBlockAfterInsertXsdString>()?.Text;
  }
  
  private static bool CmpEventDocBuildingBlockAfterInsertXsdString(DXOW.DocEvents openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXOW.EventDocBuildingBlockAfterInsertXsdString>()?.Text == value;
  }
  
  private static void SetEventDocBuildingBlockAfterInsertXsdString(DXOW.DocEvents openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.EventDocBuildingBlockAfterInsertXsdString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXOW.EventDocBuildingBlockAfterInsertXsdString { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.DocEvents? CreateModelElement(DXOW.DocEvents? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DocEvents();
      value.EventDocNewXsdString = GetEventDocNewXsdString(openXmlElement);
      value.EventDocOpenXsdString = GetEventDocOpenXsdString(openXmlElement);
      value.EventDocCloseXsdString = GetEventDocCloseXsdString(openXmlElement);
      value.EventDocSyncXsdString = GetEventDocSyncXsdString(openXmlElement);
      value.EventDocXmlAfterInsertXsdString = GetEventDocXmlAfterInsertXsdString(openXmlElement);
      value.EventDocXmlBeforeDeleteXsdString = GetEventDocXmlBeforeDeleteXsdString(openXmlElement);
      value.EventDocContentControlAfterInsertXsdString = GetEventDocContentControlAfterInsertXsdString(openXmlElement);
      value.EventDocContentControlBeforeDeleteXsdString = GetEventDocContentControlBeforeDeleteXsdString(openXmlElement);
      value.EventDocContentControlOnExistXsdString = GetEventDocContentControlOnExistXsdString(openXmlElement);
      value.EventDocContentControlOnEnterXsdString = GetEventDocContentControlOnEnterXsdString(openXmlElement);
      value.EventDocStoreUpdateXsdString = GetEventDocStoreUpdateXsdString(openXmlElement);
      value.EventDocContentControlUpdateXsdString = GetEventDocContentControlUpdateXsdString(openXmlElement);
      value.EventDocBuildingBlockAfterInsertXsdString = GetEventDocBuildingBlockAfterInsertXsdString(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOW.DocEvents? openXmlElement, DMW.DocEvents? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEventDocNewXsdString(openXmlElement, value.EventDocNewXsdString, diffs, objName))
        ok = false;
      if (!CmpEventDocOpenXsdString(openXmlElement, value.EventDocOpenXsdString, diffs, objName))
        ok = false;
      if (!CmpEventDocCloseXsdString(openXmlElement, value.EventDocCloseXsdString, diffs, objName))
        ok = false;
      if (!CmpEventDocSyncXsdString(openXmlElement, value.EventDocSyncXsdString, diffs, objName))
        ok = false;
      if (!CmpEventDocXmlAfterInsertXsdString(openXmlElement, value.EventDocXmlAfterInsertXsdString, diffs, objName))
        ok = false;
      if (!CmpEventDocXmlBeforeDeleteXsdString(openXmlElement, value.EventDocXmlBeforeDeleteXsdString, diffs, objName))
        ok = false;
      if (!CmpEventDocContentControlAfterInsertXsdString(openXmlElement, value.EventDocContentControlAfterInsertXsdString, diffs, objName))
        ok = false;
      if (!CmpEventDocContentControlBeforeDeleteXsdString(openXmlElement, value.EventDocContentControlBeforeDeleteXsdString, diffs, objName))
        ok = false;
      if (!CmpEventDocContentControlOnExistXsdString(openXmlElement, value.EventDocContentControlOnExistXsdString, diffs, objName))
        ok = false;
      if (!CmpEventDocContentControlOnEnterXsdString(openXmlElement, value.EventDocContentControlOnEnterXsdString, diffs, objName))
        ok = false;
      if (!CmpEventDocStoreUpdateXsdString(openXmlElement, value.EventDocStoreUpdateXsdString, diffs, objName))
        ok = false;
      if (!CmpEventDocContentControlUpdateXsdString(openXmlElement, value.EventDocContentControlUpdateXsdString, diffs, objName))
        ok = false;
      if (!CmpEventDocBuildingBlockAfterInsertXsdString(openXmlElement, value.EventDocBuildingBlockAfterInsertXsdString, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DocEvents? value)
    where OpenXmlElementType: DXOW.DocEvents, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEventDocNewXsdString(openXmlElement, value?.EventDocNewXsdString);
      SetEventDocOpenXsdString(openXmlElement, value?.EventDocOpenXsdString);
      SetEventDocCloseXsdString(openXmlElement, value?.EventDocCloseXsdString);
      SetEventDocSyncXsdString(openXmlElement, value?.EventDocSyncXsdString);
      SetEventDocXmlAfterInsertXsdString(openXmlElement, value?.EventDocXmlAfterInsertXsdString);
      SetEventDocXmlBeforeDeleteXsdString(openXmlElement, value?.EventDocXmlBeforeDeleteXsdString);
      SetEventDocContentControlAfterInsertXsdString(openXmlElement, value?.EventDocContentControlAfterInsertXsdString);
      SetEventDocContentControlBeforeDeleteXsdString(openXmlElement, value?.EventDocContentControlBeforeDeleteXsdString);
      SetEventDocContentControlOnExistXsdString(openXmlElement, value?.EventDocContentControlOnExistXsdString);
      SetEventDocContentControlOnEnterXsdString(openXmlElement, value?.EventDocContentControlOnEnterXsdString);
      SetEventDocStoreUpdateXsdString(openXmlElement, value?.EventDocStoreUpdateXsdString);
      SetEventDocContentControlUpdateXsdString(openXmlElement, value?.EventDocContentControlUpdateXsdString);
      SetEventDocBuildingBlockAfterInsertXsdString(openXmlElement, value?.EventDocBuildingBlockAfterInsertXsdString);
      return openXmlElement;
    }
    return default;
  }
}
