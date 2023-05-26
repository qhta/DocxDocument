namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.TableStyleConditionalTableProperties"/> class from/to OpenXml converter.
/// </summary>
public static class TableStyleConditionalFormattingTableRowPropertiesConverter
{
  public static DMW.TableStyleConditionalRowProperties? CreateModelElement(DXW.TableStyleConditionalFormattingTableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.TableStyleConditionalRowProperties();
      model.Hidden = BaseTableRowPropertiesConverter.GetHidden(openXmlElement);
      model.CantSplit = BaseTableRowPropertiesConverter.GetCantSplit(openXmlElement);
      model.TableHeader = BaseTableRowPropertiesConverter.GetTableHeader(openXmlElement);
      model.TableCellSpacing = BaseTableRowPropertiesConverter.GetTableCellSpacing(openXmlElement);
      model.TableJustification = BaseTableRowPropertiesConverter.GetTableJustification(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableStyleConditionalFormattingTableRowProperties? openXmlElement, DMW.TableStyleConditionalRowProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!BaseTableRowPropertiesConverter.CmpHidden(openXmlElement, model.Hidden, diffs, objName, propName))
        ok = false;
      if (!BaseTableRowPropertiesConverter.CmpCantSplit(openXmlElement, model.CantSplit, diffs, objName, propName))
        ok = false;
      if (!BaseTableRowPropertiesConverter.CmpTableHeader(openXmlElement, model.TableHeader, diffs, objName, propName))
        ok = false;
      if (!BaseTableRowPropertiesConverter.CmpTableCellSpacing(openXmlElement, model.TableCellSpacing, diffs, objName, propName))
        ok = false;
      if (!BaseTableRowPropertiesConverter.CmpTableJustification(openXmlElement, model.TableJustification, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableStyleConditionalRowProperties model)
    where OpenXmlElementType: DXW.TableStyleConditionalFormattingTableRowProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement, DMW.TableStyleConditionalRowProperties model)
  {
    BaseTableRowPropertiesConverter.SetHidden(openXmlElement, model?.Hidden);
    BaseTableRowPropertiesConverter.SetCantSplit(openXmlElement, model?.CantSplit);
    BaseTableRowPropertiesConverter.SetTableHeader(openXmlElement, model?.TableHeader);
    BaseTableRowPropertiesConverter.SetTableCellSpacing(openXmlElement, model?.TableCellSpacing);
    BaseTableRowPropertiesConverter.SetTableJustification(openXmlElement, model?.TableJustification);
  }
}
