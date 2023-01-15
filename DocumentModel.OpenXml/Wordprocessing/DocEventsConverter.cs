using DocumentFormat.OpenXml.Office.Word;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the DocEvents Class.
/// </summary>
public static class DocEventsConverter
{
  /// <summary>
  ///   EventDocNewXsdString.
  /// </summary>
  public static String? GetEventDocNewXsdString(DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EventDocNewXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetEventDocNewXsdString(DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EventDocNewXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EventDocNewXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EventDocOpenXsdString.
  /// </summary>
  public static String? GetEventDocOpenXsdString(DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EventDocOpenXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetEventDocOpenXsdString(DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EventDocOpenXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EventDocOpenXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EventDocCloseXsdString.
  /// </summary>
  public static String? GetEventDocCloseXsdString(DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EventDocCloseXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetEventDocCloseXsdString(DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EventDocCloseXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EventDocCloseXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EventDocSyncXsdString.
  /// </summary>
  public static String? GetEventDocSyncXsdString(DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EventDocSyncXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetEventDocSyncXsdString(DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EventDocSyncXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EventDocSyncXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EventDocXmlAfterInsertXsdString.
  /// </summary>
  public static String? GetEventDocXmlAfterInsertXsdString(DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EventDocXmlAfterInsertXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetEventDocXmlAfterInsertXsdString(DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EventDocXmlAfterInsertXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EventDocXmlAfterInsertXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EventDocXmlBeforeDeleteXsdString.
  /// </summary>
  public static String? GetEventDocXmlBeforeDeleteXsdString(DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EventDocXmlBeforeDeleteXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetEventDocXmlBeforeDeleteXsdString(DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EventDocXmlBeforeDeleteXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EventDocXmlBeforeDeleteXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EventDocContentControlAfterInsertXsdString.
  /// </summary>
  public static String? GetEventDocContentControlAfterInsertXsdString(DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EventDocContentControlAfterInsertXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetEventDocContentControlAfterInsertXsdString(DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EventDocContentControlAfterInsertXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EventDocContentControlAfterInsertXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EventDocContentControlBeforeDeleteXsdString.
  /// </summary>
  public static String? GetEventDocContentControlBeforeDeleteXsdString(DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EventDocContentControlBeforeDeleteXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetEventDocContentControlBeforeDeleteXsdString(DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EventDocContentControlBeforeDeleteXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EventDocContentControlBeforeDeleteXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EventDocContentControlOnExistXsdString.
  /// </summary>
  public static String? GetEventDocContentControlOnExistXsdString(DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EventDocContentControlOnExistXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetEventDocContentControlOnExistXsdString(DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EventDocContentControlOnExistXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EventDocContentControlOnExistXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EventDocContentControlOnEnterXsdString.
  /// </summary>
  public static String? GetEventDocContentControlOnEnterXsdString(DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EventDocContentControlOnEnterXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetEventDocContentControlOnEnterXsdString(DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EventDocContentControlOnEnterXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EventDocContentControlOnEnterXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EventDocStoreUpdateXsdString.
  /// </summary>
  public static String? GetEventDocStoreUpdateXsdString(DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EventDocStoreUpdateXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetEventDocStoreUpdateXsdString(DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EventDocStoreUpdateXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EventDocStoreUpdateXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EventDocContentControlUpdateXsdString.
  /// </summary>
  public static String? GetEventDocContentControlUpdateXsdString(DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EventDocContentControlUpdateXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetEventDocContentControlUpdateXsdString(DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EventDocContentControlUpdateXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EventDocContentControlUpdateXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EventDocBuildingBlockAfterInsertXsdString.
  /// </summary>
  public static String? GetEventDocBuildingBlockAfterInsertXsdString(DocEvents? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EventDocBuildingBlockAfterInsertXsdString>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetEventDocBuildingBlockAfterInsertXsdString(DocEvents? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EventDocBuildingBlockAfterInsertXsdString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new EventDocBuildingBlockAfterInsertXsdString { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.DocEvents? CreateModelElement(DocEvents? openXmlElement)
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
    where OpenXmlElementType : DocEvents, new()
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