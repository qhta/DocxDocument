namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.BorderBoxProperties"/> class from/to OpenXml converter.
/// </summary>
public static class BorderBoxPropertiesConverter
{
  #region Hide Top Edge conversion.
  private static bool? GetHideTop(DXM.BorderBoxProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.HideTop>()?.Val?.Value);
  }
  
  private static bool CmpHideTop(DXM.BorderBoxProperties openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.HideTop>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetHideTop(DXM.BorderBoxProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.HideTop>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(BooleanValueConverter.CreateOpenXmlElement<DXM.HideTop>((bool)value));
  }
  #endregion

  #region Hide Bottom Edge conversion.
  private static bool? GetHideBottom(DXM.BorderBoxProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.HideBottom>()?.Val?.Value);
  }
  
  private static bool CmpHideBottom(DXM.BorderBoxProperties openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.HideBottom>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetHideBottom(DXM.BorderBoxProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.HideBottom>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(BooleanValueConverter.CreateOpenXmlElement<DXM.HideBottom>((bool)value));
  }
  #endregion

  #region Hide Left Edge conversion.
  private static bool? GetHideLeft(DXM.BorderBoxProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.HideLeft>()?.Val?.Value);
  }
  
  private static bool CmpHideLeft(DXM.BorderBoxProperties openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.HideLeft>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetHideLeft(DXM.BorderBoxProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.HideLeft>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(BooleanValueConverter.CreateOpenXmlElement<DXM.HideLeft>((bool)value));
  }
  #endregion

  #region Hide Right Edge conversion.
  private static bool? GetHideRight(DXM.BorderBoxProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.HideRight>()?.Val?.Value);
  }
  
  private static bool CmpHideRight(DXM.BorderBoxProperties openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.HideRight>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetHideRight(DXM.BorderBoxProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.HideRight>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(BooleanValueConverter.CreateOpenXmlElement<DXM.HideRight>((bool)value));
  }
  #endregion

  #region Border Box Strikethrough Horizontal conversion.
  private static bool? GetStrikeHorizontal(DXM.BorderBoxProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.StrikeHorizontal>()?.Val?.Value);
  }
  
  private static bool CmpStrikeHorizontal(DXM.BorderBoxProperties openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.StrikeHorizontal>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetStrikeHorizontal(DXM.BorderBoxProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.StrikeHorizontal>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(BooleanValueConverter.CreateOpenXmlElement<DXM.StrikeHorizontal>((bool)value));
  }
  #endregion

  #region Border Box Strikethrough Vertical conversion.
  private static bool? GetStrikeVertical(DXM.BorderBoxProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.StrikeVertical>()?.Val?.Value);
  }
  
  private static bool CmpStrikeVertical(DXM.BorderBoxProperties openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.StrikeVertical>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetStrikeVertical(DXM.BorderBoxProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.StrikeVertical>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(BooleanValueConverter.CreateOpenXmlElement<DXM.StrikeVertical>((bool)value));
  }
  #endregion

  #region Border Box Strikethrough Bottom-Left to Top-Right conversion.
  private static bool? GetStrikeBottomLeftToTopRight(DXM.BorderBoxProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.StrikeBottomLeftToTopRight>()?.Val?.Value);
  }
  
  private static bool CmpStrikeBottomLeftToTopRight(DXM.BorderBoxProperties openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.StrikeBottomLeftToTopRight>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetStrikeBottomLeftToTopRight(DXM.BorderBoxProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.StrikeBottomLeftToTopRight>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(BooleanValueConverter.CreateOpenXmlElement<DXM.StrikeBottomLeftToTopRight>((bool)value));
  }
  #endregion

  #region Border Box Strikethrough Top-Left to Bottom-Right conversion.
  private static bool? GetStrikeTopLeftToBottomRight(DXM.BorderBoxProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.StrikeTopLeftToBottomRight>()?.Val?.Value);
  }
  
  private static bool CmpStrikeTopLeftToBottomRight(DXM.BorderBoxProperties openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.StrikeTopLeftToBottomRight>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetStrikeTopLeftToBottomRight(DXM.BorderBoxProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.StrikeTopLeftToBottomRight>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(BooleanValueConverter.CreateOpenXmlElement<DXM.StrikeTopLeftToBottomRight>((bool)value));
  }
  #endregion

  #region ControlProperties conversion.
  private static DMM.ControlProperties? GetControlProperties(DXM.BorderBoxProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ControlProperties>();
    if (element != null)
      return DMXM.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXM.BorderBoxProperties openXmlElement, DMM.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ControlProperties>(), value, diffs, objName);
  }
  
  private static void SetControlProperties(DXM.BorderBoxProperties openXmlElement, DMM.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.ControlPropertiesConverter.CreateOpenXmlElement<DXM.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region BorderBoxProperties model conversion.
  public static DMM.BorderBoxProperties? CreateModelElement(DXM.BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.BorderBoxProperties();
      model.HideTop = GetHideTop(openXmlElement);
      model.HideBottom = GetHideBottom(openXmlElement);
      model.HideLeft = GetHideLeft(openXmlElement);
      model.HideRight = GetHideRight(openXmlElement);
      model.StrikeHorizontal = GetStrikeHorizontal(openXmlElement);
      model.StrikeVertical = GetStrikeVertical(openXmlElement);
      model.StrikeBottomLeftToTopRight = GetStrikeBottomLeftToTopRight(openXmlElement);
      model.StrikeTopLeftToBottomRight = GetStrikeTopLeftToBottomRight(openXmlElement);
      model.ControlProperties = GetControlProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.BorderBoxProperties? openXmlElement, DMM.BorderBoxProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpHideTop(openXmlElement, model.HideTop, diffs, objName))
        ok = false;
      if (!CmpHideBottom(openXmlElement, model.HideBottom, diffs, objName))
        ok = false;
      if (!CmpHideLeft(openXmlElement, model.HideLeft, diffs, objName))
        ok = false;
      if (!CmpHideRight(openXmlElement, model.HideRight, diffs, objName))
        ok = false;
      if (!CmpStrikeHorizontal(openXmlElement, model.StrikeHorizontal, diffs, objName))
        ok = false;
      if (!CmpStrikeVertical(openXmlElement, model.StrikeVertical, diffs, objName))
        ok = false;
      if (!CmpStrikeBottomLeftToTopRight(openXmlElement, model.StrikeBottomLeftToTopRight, diffs, objName))
        ok = false;
      if (!CmpStrikeTopLeftToBottomRight(openXmlElement, model.StrikeTopLeftToBottomRight, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, model.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.BorderBoxProperties model)
    where OpenXmlElementType: DXM.BorderBoxProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.BorderBoxProperties openXmlElement, DMM.BorderBoxProperties model)
  {
    SetHideTop(openXmlElement, model?.HideTop);
    SetHideBottom(openXmlElement, model?.HideBottom);
    SetHideLeft(openXmlElement, model?.HideLeft);
    SetHideRight(openXmlElement, model?.HideRight);
    SetStrikeHorizontal(openXmlElement, model?.StrikeHorizontal);
    SetStrikeVertical(openXmlElement, model?.StrikeVertical);
    SetStrikeBottomLeftToTopRight(openXmlElement, model?.StrikeBottomLeftToTopRight);
    SetStrikeTopLeftToBottomRight(openXmlElement, model?.StrikeTopLeftToBottomRight);
    SetControlProperties(openXmlElement, model?.ControlProperties);
  }
  #endregion
}
