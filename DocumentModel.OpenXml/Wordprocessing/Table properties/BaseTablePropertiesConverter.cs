namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.BaseTableProperties"/> class from/to OpenXml converter.
/// </summary>
public static class BaseTablePropertiesConverter
{
  #region TableJustification conversion.
  public static DMW.TableRowAlignmentKind? GetTableJustification(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value);
  }

  public static bool CmpTableJustification(DX.OpenXmlCompositeElement openXmlElement, DMW.TableRowAlignmentKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value, value, diffs, objName, propName);
  }

  public static void SetTableJustification(DX.OpenXmlCompositeElement openXmlElement, DMW.TableRowAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableJustification>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(itemElement, (DMW.TableRowAlignmentKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.TableJustification, DXW.TableRowAlignmentValues, DMW.TableRowAlignmentKind>((DMW.TableRowAlignmentKind)value));
  }
  #endregion

  #region TableCellSpacing conversion.
  public static DMW.TableWidth? GetTableCellSpacing(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellSpacing>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpTableCellSpacing(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellSpacing>(), value, diffs, objName, propName);
  }

  public static void SetTableCellSpacing(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.TableCellSpacing>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TableIndentation conversion.
  public static DMW.TableWidth? GetTableIndentation(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableIndentation>();
    if (element != null)
      return DMXW.TableIndentationConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpTableIndentation(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.TableIndentationConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableIndentation>(), value, diffs, objName, propName);
  }

  public static void SetTableIndentation(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableIndentation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableIndentationConverter.CreateOpenXmlElement<DXW.TableIndentation>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TableBorders conversion.
  public static DMW.TableBorders? GetTableBorders(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableBorders>();
    if (element != null)
      return DMXW.TableBordersConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpTableBorders(DX.OpenXmlCompositeElement openXmlElement, DMW.TableBorders? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.TableBordersConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableBorders>(), value, diffs, objName, propName);
  }

  public static void SetTableBorders(DX.OpenXmlCompositeElement openXmlElement, DMW.TableBorders? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableBorders>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableBordersConverter.CreateOpenXmlElement<DXW.TableBorders>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Shading conversion.
  public static DMW.Shading? GetShading(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (element != null)
      return DMXW.ShadingConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpShading(DX.OpenXmlCompositeElement openXmlElement, DMW.Shading? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Shading>(), value, diffs, objName, propName);
  }

  public static void SetShading(DX.OpenXmlCompositeElement openXmlElement, DMW.Shading? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Shading>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ShadingConverter.CreateOpenXmlElement<DXW.Shading>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TableCellMarginDefault conversion.
  public static DMW.DefaultTableCellMargin? GetTableCellMarginDefault(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellMarginDefault>();
    if (element != null)
      return DMXW.DefaultTableCellMarginConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpTableCellMarginDefault(DX.OpenXmlCompositeElement openXmlElement, DMW.DefaultTableCellMargin? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.DefaultTableCellMarginConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellMarginDefault>(), value, diffs, objName, propName);
  }

  public static void SetTableCellMarginDefault(DX.OpenXmlCompositeElement openXmlElement, DMW.DefaultTableCellMargin? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellMarginDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DefaultTableCellMarginConverter.CreateOpenXmlElement<DXW.TableCellMarginDefault>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region BaseTableProperties model conversion.
  public static void UpdateModelElement(DMW.BaseTableProperties model, DX.OpenXmlCompositeElement openXmlElement)
  {
    model.TableJustification = GetTableJustification(openXmlElement);
    model.TableCellSpacing = GetTableCellSpacing(openXmlElement);
    model.TableIndentation = GetTableIndentation(openXmlElement);
    model.TableBorders = GetTableBorders(openXmlElement);
    model.Shading = GetShading(openXmlElement);
    model.DefaultTableCellMargin = GetTableCellMarginDefault(openXmlElement);
  }

  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.BaseTableProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpTableJustification(openXmlElement, model.TableJustification, diffs, objName, propName))
        ok = false;
      if (!CmpTableCellSpacing(openXmlElement, model.TableCellSpacing, diffs, objName, propName))
        ok = false;
      if (!CmpTableIndentation(openXmlElement, model.TableIndentation, diffs, objName, propName))
        ok = false;
      if (!CmpTableBorders(openXmlElement, model.TableBorders, diffs, objName, propName))
        ok = false;
      if (!CmpShading(openXmlElement, model.Shading, diffs, objName, propName))
        ok = false;
      if (!CmpTableCellMarginDefault(openXmlElement, model.DefaultTableCellMargin, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMW.BaseTableProperties model)
  {
    SetTableJustification(openXmlElement, model?.TableJustification);
    SetTableCellSpacing(openXmlElement, model?.TableCellSpacing);
    SetTableIndentation(openXmlElement, model?.TableIndentation);
    SetTableBorders(openXmlElement, model?.TableBorders);
    SetShading(openXmlElement, model?.Shading);
    SetTableCellMarginDefault(openXmlElement, model?.DefaultTableCellMargin);
  }
  #endregion
}
