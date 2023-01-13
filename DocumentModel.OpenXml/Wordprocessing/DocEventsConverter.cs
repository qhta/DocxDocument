namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the DocEvents Class.
/// </summary>
public static class DocEventsConverter
{
  /// <summary>
  /// EventDocNewXsdString.
  /// </summary>
  public static String? GetEventDocNewXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocNewXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetEventDocNewXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocNewXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office.Word.EventDocNewXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// EventDocOpenXsdString.
  /// </summary>
  public static String? GetEventDocOpenXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocOpenXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetEventDocOpenXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocOpenXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office.Word.EventDocOpenXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// EventDocCloseXsdString.
  /// </summary>
  public static String? GetEventDocCloseXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocCloseXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetEventDocCloseXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocCloseXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office.Word.EventDocCloseXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// EventDocSyncXsdString.
  /// </summary>
  public static String? GetEventDocSyncXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocSyncXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetEventDocSyncXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocSyncXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office.Word.EventDocSyncXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// EventDocXmlAfterInsertXsdString.
  /// </summary>
  public static String? GetEventDocXmlAfterInsertXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocXmlAfterInsertXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetEventDocXmlAfterInsertXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocXmlAfterInsertXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office.Word.EventDocXmlAfterInsertXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// EventDocXmlBeforeDeleteXsdString.
  /// </summary>
  public static String? GetEventDocXmlBeforeDeleteXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocXmlBeforeDeleteXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetEventDocXmlBeforeDeleteXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocXmlBeforeDeleteXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office.Word.EventDocXmlBeforeDeleteXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// EventDocContentControlAfterInsertXsdString.
  /// </summary>
  public static String? GetEventDocContentControlAfterInsertXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocContentControlAfterInsertXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetEventDocContentControlAfterInsertXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocContentControlAfterInsertXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office.Word.EventDocContentControlAfterInsertXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// EventDocContentControlBeforeDeleteXsdString.
  /// </summary>
  public static String? GetEventDocContentControlBeforeDeleteXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocContentControlBeforeDeleteXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetEventDocContentControlBeforeDeleteXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocContentControlBeforeDeleteXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office.Word.EventDocContentControlBeforeDeleteXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// EventDocContentControlOnExistXsdString.
  /// </summary>
  public static String? GetEventDocContentControlOnExistXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnExistXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetEventDocContentControlOnExistXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnExistXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnExistXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// EventDocContentControlOnEnterXsdString.
  /// </summary>
  public static String? GetEventDocContentControlOnEnterXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnEnterXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetEventDocContentControlOnEnterXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnEnterXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office.Word.EventDocContentControlOnEnterXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// EventDocStoreUpdateXsdString.
  /// </summary>
  public static String? GetEventDocStoreUpdateXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocStoreUpdateXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetEventDocStoreUpdateXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocStoreUpdateXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office.Word.EventDocStoreUpdateXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// EventDocContentControlUpdateXsdString.
  /// </summary>
  public static String? GetEventDocContentControlUpdateXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocContentControlUpdateXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetEventDocContentControlUpdateXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocContentControlUpdateXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office.Word.EventDocContentControlUpdateXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// EventDocBuildingBlockAfterInsertXsdString.
  /// </summary>
  public static String? GetEventDocBuildingBlockAfterInsertXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocBuildingBlockAfterInsertXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetEventDocBuildingBlockAfterInsertXsdString(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.EventDocBuildingBlockAfterInsertXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office.Word.EventDocBuildingBlockAfterInsertXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.DocEvents? CreateModelElement(DocumentFormat.OpenXml.Office.Word.DocEvents? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DocEvents();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DocEvents? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.DocEvents, new()
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
