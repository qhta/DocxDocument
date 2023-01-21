namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MoveFromMathControl Class.
/// </summary>
public static class MoveFromMathControlConverter
{
  private static DMW.RunProperties? GetRunProperties(DXW.MoveFromMathControl openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.RunProperties>();
    if (itemElement != null)
      return DMXW.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunProperties(DXW.MoveFromMathControl openXmlElement, DMW.RunProperties? value)
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
  
  private static DMW.InsertedMathControl? GetInsertedMathControl(DXW.MoveFromMathControl openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.InsertedMathControl>();
    if (itemElement != null)
      return DMXW.InsertedMathControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetInsertedMathControl(DXW.MoveFromMathControl openXmlElement, DMW.InsertedMathControl? value)
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
  
  private static DMW.DeletedMathControl? GetDeletedMathControl(DXW.MoveFromMathControl openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.DeletedMathControl>();
    if (itemElement != null)
      return DMXW.DeletedMathControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDeletedMathControl(DXW.MoveFromMathControl openXmlElement, DMW.DeletedMathControl? value)
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
  
  public static DMW.MoveFromMathControl? CreateModelElement(DXW.MoveFromMathControl? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.MoveFromMathControl();
      value.RunProperties = GetRunProperties(openXmlElement);
      value.InsertedMathControl = GetInsertedMathControl(openXmlElement);
      value.DeletedMathControl = GetDeletedMathControl(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.MoveFromMathControl? value)
    where OpenXmlElementType: DXW.MoveFromMathControl, new()
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
