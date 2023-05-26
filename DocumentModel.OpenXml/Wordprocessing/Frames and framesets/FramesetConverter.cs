namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Frameset"/> class from/to OpenXml converter.
/// </summary>
public static class FramesetConverter
{
  #region item conversion
  private static DM.IModelElement? GetItem(DX.OpenXmlElement openXmlElement, object? data = null)
  {
    var settings = data as DXW.WebSettings;
    if (openXmlElement is DXW.Frameset frameset)
      return CreateModelElement(frameset, settings);
    if (openXmlElement is DXW.Frame frame)
      return FrameConverter.CreateModelElement(frame, settings);

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in FramesetConverter.CreateModelElement method");
    return null;

  }

  private static bool CmpItem(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, 
    DiffList? diffs = null, string? objName = null, string? propName = null, object? data = null)
  {
    var settings = data as DXW.WebSettings;
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.Frameset framesetElement && model is DMW.Frameset framesetModel)
        return CompareModelElement(framesetElement, framesetModel, diffs, objName, propName, settings);

      if (openXmlElement is DXW.Frame frameElement && model is DMW.Frame frameModel)
        return FrameConverter.CompareModelElement(frameElement, frameModel, diffs, objName, propName, settings);

      diffs?.Add(objName, "Type", openXmlElement.GetType().Name, model.GetType().Name);
      return false;

    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;  }

  private static bool UpdateItem(DX.OpenXmlElement openXmlElement, DM.IModelElement model, object? data = null)
  {
    var settings = data as DXW.WebSettings;
    if (openXmlElement is DXW.Frameset framesetElement && model is DMW.Frameset framesetModel)
      return UpdateOpenXmlElement(framesetElement, framesetModel, settings);

    if (openXmlElement is DXW.Frame frameElement && model is DMW.Frame frameModel)
      return FrameConverter.UpdateOpenXmlElement(frameElement, frameModel, settings);
    return false;
  }

  private static OpenXmlElement CreateItemElement(DM.IModelElement model, object? data = null)
  {
    var settings = data as DXW.WebSettings;
    if (model is DMW.Frameset framesetModel)
     return CreateOpenXmlElement(framesetModel, settings);

    if (model is DMW.Frame frameModel)
     return FrameConverter.CreateOpenXmlElement(frameModel, settings);

    return null!;
  }
  #endregion

  #region FrameSize conversion.
  private static UInt32? GetFrameSize(DXW.Frameset openXmlElement)
  {
    return UInt32ValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.FrameSize>()?.Val?.Value);
  }
  
  private static bool CmpFrameSize(DXW.Frameset openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FrameSize>();
    if (itemElement?.Val?.Value == value.ToString()) return true;
    diffs?.Add(objName, "FrameSize", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetFrameSize(DXW.Frameset openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FrameSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.FrameSize { Val = value.ToString() };
      openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region FramesetSplitbar conversion.
  private static DMW.FramesetSplitbar? GetFramesetSplitbar(DXW.Frameset openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.FramesetSplitbar>();
    if (element != null)
      return DMXW.FramesetSplitbarConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFramesetSplitbar(DXW.Frameset openXmlElement, DMW.FramesetSplitbar? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.FramesetSplitbarConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FramesetSplitbar>(), value, diffs, objName, propName);
  }
  
  private static void SetFramesetSplitbar(DXW.Frameset openXmlElement, DMW.FramesetSplitbar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FramesetSplitbar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FramesetSplitbarConverter.CreateOpenXmlElement<DXW.FramesetSplitbar>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region FrameLayout conversion.
  /// </summary>
  private static DMW.FrameLayoutKind? GetFrameLayout(DXW.Frameset openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.FrameLayoutValues, DMW.FrameLayoutKind>(openXmlElement.GetFirstChild<DXW.FrameLayout>()?.Val?.Value);
  }
  
  private static bool CmpFrameLayout(DXW.Frameset openXmlElement, DMW.FrameLayoutKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.FrameLayoutValues, DMW.FrameLayoutKind>(openXmlElement.GetFirstChild<DXW.FrameLayout>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetFrameLayout(DXW.Frameset openXmlElement, DMW.FrameLayoutKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FrameLayout>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.FrameLayoutValues, DMW.FrameLayoutKind>(itemElement, (DMW.FrameLayoutKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.FrameLayout, DXW.FrameLayoutValues, DMW.FrameLayoutKind>((DMW.FrameLayoutKind)value));
  }
  #endregion

  #region Frameset model conversion.
  public static DMW.Frameset? CreateModelElement(DXW.Frameset? openXmlElement, DXW.WebSettings? settings)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Frameset();
      model.FrameSize = GetFrameSize(openXmlElement);
      model.FramesetSplitbar = GetFramesetSplitbar(openXmlElement);
      model.FrameLayout = GetFrameLayout(openXmlElement);
      ElementCollectionConverter<DMW.IFramesetItem>.FillModelElementCollection(
        openXmlElement.Where(item=>item is DXW.Frameset or DXW.Frame), model,
        GetItem, settings);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Frameset? openXmlElement, DMW.Frameset? model, DiffList? diffs, string? objName, string? propName, DXW.WebSettings? settings)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpFrameSize(openXmlElement, model.FrameSize, diffs, objName, propName))
        ok = false;
      if (!CmpFramesetSplitbar(openXmlElement, model.FramesetSplitbar, diffs, objName, propName))
        ok = false;
      if (!CmpFrameLayout(openXmlElement, model.FrameLayout, diffs, objName, propName))
        ok = false;
      if (!ElementCollectionConverter<DMW.IFramesetItem>.CompareOpenXmlElementCollection(
        openXmlElement.Where(item=>item is DXW.Frameset or DXW.Frame), model,
        CmpItem, diffs, objName, propName, settings))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXW.Frameset CreateOpenXmlElement(DMW.Frameset model, DXW.WebSettings? settings)
  {
    var openXmlElement = new DXW.Frameset();
    UpdateOpenXmlElement(openXmlElement, model, settings);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.Frameset openXmlElement, DMW.Frameset model, DXW.WebSettings? settings)
  {
    SetFrameSize(openXmlElement, model.FrameSize);
    SetFramesetSplitbar(openXmlElement, model.FramesetSplitbar);
    SetFrameLayout(openXmlElement, model.FrameLayout);
    return ElementCollectionConverter<DMW.IFramesetItem>.UpdateOpenXmlElementCollection(
      openXmlElement,
      (item=>item is DXW.Frameset or DXW.Frame),
      model,
      CmpItem,
      UpdateItem,
      CreateItemElement,
      settings
    );
  }
  #endregion
}
