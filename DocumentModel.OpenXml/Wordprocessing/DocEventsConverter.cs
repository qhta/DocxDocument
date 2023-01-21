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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.EventDocNewXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.EventDocOpenXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.EventDocCloseXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.EventDocSyncXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.EventDocXmlAfterInsertXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.EventDocXmlBeforeDeleteXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.EventDocContentControlAfterInsertXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.EventDocContentControlBeforeDeleteXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.EventDocContentControlOnExistXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.EventDocContentControlOnEnterXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.EventDocStoreUpdateXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.EventDocContentControlUpdateXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.EventDocBuildingBlockAfterInsertXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
