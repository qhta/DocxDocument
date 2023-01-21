namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MoveToMathControl Class.
/// </summary>
public static class MoveToMathControlConverter
{
  private static DMW.RunProperties? GetRunProperties(DXW.MoveToMathControl openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.RunProperties>();
    if (itemElement != null)
      return DMXW.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunProperties(DXW.MoveToMathControl openXmlElement, DMW.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunPropertiesConverter.CreateOpenXmlElement<DXW.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.InsertedMathControl? GetInsertedMathControl(DXW.MoveToMathControl openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.InsertedMathControl>();
    if (itemElement != null)
      return DMXW.InsertedMathControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetInsertedMathControl(DXW.MoveToMathControl openXmlElement, DMW.InsertedMathControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.InsertedMathControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.InsertedMathControlConverter.CreateOpenXmlElement<DXW.InsertedMathControl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.DeletedMathControl? GetDeletedMathControl(DXW.MoveToMathControl openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.DeletedMathControl>();
    if (itemElement != null)
      return DMXW.DeletedMathControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDeletedMathControl(DXW.MoveToMathControl openXmlElement, DMW.DeletedMathControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DeletedMathControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DeletedMathControlConverter.CreateOpenXmlElement<DXW.DeletedMathControl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.MoveToMathControl? CreateModelElement(DXW.MoveToMathControl? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.MoveToMathControl();
      value.RunProperties = GetRunProperties(openXmlElement);
      value.InsertedMathControl = GetInsertedMathControl(openXmlElement);
      value.DeletedMathControl = GetDeletedMathControl(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.MoveToMathControl? value)
    where OpenXmlElementType: DXW.MoveToMathControl, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunProperties(openXmlElement, value?.RunProperties);
      SetInsertedMathControl(openXmlElement, value?.InsertedMathControl);
      SetDeletedMathControl(openXmlElement, value?.DeletedMathControl);
      return openXmlElement;
    }
    return default;
  }
}
