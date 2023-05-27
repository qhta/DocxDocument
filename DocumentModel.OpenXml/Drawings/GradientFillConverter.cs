namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the GradientFill Class.
/// </summary>
public static class GradientFillConverter
{
  #region TileFlip conversion.
  private static DMD.TileFlipKind? GetFlip(DXD.GradientFill openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DMD.TileFlipKind>(openXmlElement?.Flip?.Value);
  }

  private static bool CmpFlip(DXD.GradientFill openXmlElement, DMD.TileFlipKind? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DMD.TileFlipKind>(openXmlElement?.Flip?.Value, model, diffs, objName, propName);
  }

  private static void SetFlip(DXD.GradientFill openXmlElement, DMD.TileFlipKind? model)
  {
    openXmlElement.Flip = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DMD.TileFlipKind>(model);
  }
  #endregion

  #region RotateWithShape conversion.
  private static Boolean? GetRotateWithShape(DXD.GradientFill openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }

  private static bool CmpRotateWithShape(DXD.GradientFill openXmlElement, Boolean? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RotateWithShape?.Value == model) return true;
    diffs?.Add(objName, "RotateWithShape", openXmlElement?.RotateWithShape?.Value, model);
    return false;
  }

  private static void SetRotateWithShape(DXD.GradientFill openXmlElement, Boolean? model)
  {
    if (model != null)
      openXmlElement.RotateWithShape = new BooleanValue { Value = (Boolean)model };
    else
      openXmlElement.RotateWithShape = null;
  }
  #endregion


  #region Gradient Stop List conversion.
  private static DMD.GradientStopList? GetGradientStopList(DXD.GradientFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.GradientStopList>();
    if (element != null)
      return DMXD.GradientStopListConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpGradientStopList(DXD.GradientFill openXmlElement, DMD.GradientStopList? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.GradientStopListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.GradientStopList>(), model, diffs, objName, propName);
  }

  private static void SetGradientStopList(DXD.GradientFill openXmlElement, DMD.GradientStopList? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.GradientStopList>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.GradientStopListConverter.CreateOpenXmlElement<DXD.GradientStopList>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region LinearGradientFill conversion.
  private static DMD.LinearGradientFill? GetLinearGradientFill(DXD.GradientFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LinearGradientFill>();
    if (element != null)
      return DMXD.LinearGradientFillConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpLinearGradientFill(DXD.GradientFill openXmlElement, DMD.LinearGradientFill? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LinearGradientFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LinearGradientFill>(), model, diffs, objName, propName);
  }

  private static void SetLinearGradientFill(DXD.GradientFill openXmlElement, DMD.LinearGradientFill? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LinearGradientFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.LinearGradientFillConverter.CreateOpenXmlElement<DXD.LinearGradientFill>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region PathGradientFill conversion.
  private static DMD.PathGradientFill? GetPathGradientFill(DXD.GradientFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PathGradientFill>();
    if (element != null)
      return DMXD.PathGradientFillConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpPathGradientFill(DXD.GradientFill openXmlElement, DMD.PathGradientFill? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.PathGradientFillConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PathGradientFill>(), model, diffs, objName, propName);
  }

  private static void SetPathGradientFill(DXD.GradientFill openXmlElement, DMD.PathGradientFill? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PathGradientFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.PathGradientFillConverter.CreateOpenXmlElement<DXD.PathGradientFill>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TileRectangle conversion.
  private static DMD.RelativeRectangleType? GetTileRectangle(DXD.GradientFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.TileRectangle>();
    if (element != null)
      return DMXD.RelativeRectangleTypeConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpTileRectangle(DXD.GradientFill openXmlElement, DMD.RelativeRectangleType? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.RelativeRectangleTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.TileRectangle>(), model, diffs, objName, propName);
  }

  private static void SetTileRectangle(DXD.GradientFill openXmlElement, DMD.RelativeRectangleType? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.TileRectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXD.RelativeRectangleTypeConverter.CreateOpenXmlElement<DXD.TileRectangle>(model);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region GradientFill model conversion.
  public static DocumentModel.Drawings.GradientFill? CreateModelElement(DXD.GradientFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      DMD.GradientFill? model = GetLinearGradientFill(openXmlElement);
      if (model == null)
        model = GetPathGradientFill(openXmlElement);
      if (model != null)
      {
        model.Flip = GetFlip(openXmlElement);
        model.RotateWithShape = GetRotateWithShape(openXmlElement);
        model.GradientStopList = GetGradientStopList(openXmlElement);
        model.TileRectangle = GetTileRectangle(openXmlElement);
      }
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXD.GradientFill? openXmlElement, DMD.GradientFill? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpFlip(openXmlElement, model.Flip, diffs, objName, propName))
        ok = false;
      if (!CmpRotateWithShape(openXmlElement, model.RotateWithShape, diffs, objName, propName))
        ok = false;
      if (!CmpGradientStopList(openXmlElement, model.GradientStopList, diffs, objName, propName))
        ok = false;
      if (!CmpTileRectangle(openXmlElement, model.TileRectangle, diffs, objName, propName))
        ok = false;
      if (model is DMD.LinearGradientFill linearGradientFill)
      {
        if (!CmpLinearGradientFill(openXmlElement, linearGradientFill, diffs, objName, propName))
          ok = false;
      }
      else
      if (model is DMD.PathGradientFill pathGradientFill)
      {
        if (!CmpPathGradientFill(openXmlElement, pathGradientFill, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXD.GradientFill CreateOpenXmlElement(DMD.GradientFill model)
  {
    var openXmlElement = new DXD.GradientFill();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXD.GradientFill openXmlElement, DMD.GradientFill model)
  {
    SetFlip(openXmlElement, model.Flip);
    SetRotateWithShape(openXmlElement, model.RotateWithShape);
    SetGradientStopList(openXmlElement, model.GradientStopList);
    SetTileRectangle(openXmlElement, model.TileRectangle);
    if (model is DMD.LinearGradientFill linearGradientFill)
    {
      SetLinearGradientFill(openXmlElement, linearGradientFill);
      return true;
    }
    else
    if (model is DMD.PathGradientFill pathGradientFill)
    {
      SetPathGradientFill(openXmlElement, pathGradientFill);
      return true;
    }
    return false;
  }
  #endregion
}
