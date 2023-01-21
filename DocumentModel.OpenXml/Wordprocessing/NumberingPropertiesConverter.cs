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
    var itemElement = openXmlElement?.GetFirstChild<DXW.NumberingLevelReference>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetNumberingLevelReference(DXW.NumberingProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NumberingLevelReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.NumberingLevelReference{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Numbering Definition Instance Reference.
  /// </summary>
  private static Int32? GetNumberingId(DXW.NumberingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.NumberingId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetNumberingId(DXW.NumberingProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NumberingId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.NumberingId{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Previous Paragraph Numbering Properties.
  /// </summary>
  private static DMW.NumberingChange? GetNumberingChange(DXW.NumberingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.NumberingChange>();
    if (itemElement != null)
      return DMXW.NumberingChangeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.Inserted>();
    if (itemElement != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMW.NumberingProperties? CreateModelElement(DXW.NumberingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.NumberingProperties();
      value.NumberingLevelReference = GetNumberingLevelReference(openXmlElement);
      value.NumberingId = GetNumberingId(openXmlElement);
      value.NumberingChange = GetNumberingChange(openXmlElement);
      value.Inserted = GetInserted(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.NumberingProperties? value)
    where OpenXmlElementType: DXW.NumberingProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberingLevelReference(openXmlElement, value?.NumberingLevelReference);
      SetNumberingId(openXmlElement, value?.NumberingId);
      SetNumberingChange(openXmlElement, value?.NumberingChange);
      SetInserted(openXmlElement, value?.Inserted);
      return openXmlElement;
    }
    return default;
  }
}
