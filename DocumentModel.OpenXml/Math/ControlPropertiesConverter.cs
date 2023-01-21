namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Control Properties.
/// </summary>
public static class ControlPropertiesConverter
{
  private static DMW.RunProperties? GetRunProperties(DXMath.ControlProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.RunProperties>();
    if (itemElement != null)
      return DMXW.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunProperties(DXMath.ControlProperties openXmlElement, DMW.RunProperties? value)
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
  
  private static DMW.InsertedMathControl? GetInsertedMathControl(DXMath.ControlProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.InsertedMathControl>();
    if (itemElement != null)
      return DMXW.InsertedMathControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetInsertedMathControl(DXMath.ControlProperties openXmlElement, DMW.InsertedMathControl? value)
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
  
  private static DMW.DeletedMathControl? GetDeletedMathControl(DXMath.ControlProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.DeletedMathControl>();
    if (itemElement != null)
      return DMXW.DeletedMathControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDeletedMathControl(DXMath.ControlProperties openXmlElement, DMW.DeletedMathControl? value)
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
  
  private static DMW.MoveFromMathControl? GetMoveFromMathControl(DXMath.ControlProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveFromMathControl>();
    if (itemElement != null)
      return DMXW.MoveFromMathControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveFromMathControl(DXMath.ControlProperties openXmlElement, DMW.MoveFromMathControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveFromMathControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveFromMathControlConverter.CreateOpenXmlElement<DXW.MoveFromMathControl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.MoveToMathControl? GetMoveToMathControl(DXMath.ControlProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.MoveToMathControl>();
    if (itemElement != null)
      return DMXW.MoveToMathControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMoveToMathControl(DXMath.ControlProperties openXmlElement, DMW.MoveToMathControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MoveToMathControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MoveToMathControlConverter.CreateOpenXmlElement<DXW.MoveToMathControl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.ControlProperties? CreateModelElement(DXMath.ControlProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.ControlProperties();
      value.RunProperties = GetRunProperties(openXmlElement);
      value.InsertedMathControl = GetInsertedMathControl(openXmlElement);
      value.DeletedMathControl = GetDeletedMathControl(openXmlElement);
      value.MoveFromMathControl = GetMoveFromMathControl(openXmlElement);
      value.MoveToMathControl = GetMoveToMathControl(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.ControlProperties? value)
    where OpenXmlElementType: DXMath.ControlProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunProperties(openXmlElement, value?.RunProperties);
      SetInsertedMathControl(openXmlElement, value?.InsertedMathControl);
      SetDeletedMathControl(openXmlElement, value?.DeletedMathControl);
      SetMoveFromMathControl(openXmlElement, value?.MoveFromMathControl);
      SetMoveToMathControl(openXmlElement, value?.MoveToMathControl);
      return openXmlElement;
    }
    return default;
  }
}
