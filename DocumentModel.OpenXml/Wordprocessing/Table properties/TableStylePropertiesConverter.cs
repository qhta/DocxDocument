namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.TableStyleProperties"/> class from/to OpenXml converter.
/// </summary>
public static class TableStylePropertiesConverter
{
  #region TableTableStyleOverrideType conversion.
  private static DMW.TableStyleOverrideKind? GetType(DXW.TableStyleProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableStyleOverrideValues, DMW.TableStyleOverrideKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.TableStyleProperties openXmlElement, DMW.TableStyleOverrideKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableStyleOverrideValues, DMW.TableStyleOverrideKind>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXW.TableStyleProperties openXmlElement, DMW.TableStyleOverrideKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableStyleOverrideValues, DMW.TableStyleOverrideKind>(value);
  }
  #endregion

  #region Table Style Conditional Formatting Paragraph Properties conversion.
  private static DMW.StyleParagraphProperties? GetStyleParagraphProperties(DXW.TableStyleProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.StyleParagraphProperties>();
    if (element != null)
      return DMXW.StyleParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyleParagraphProperties(DXW.TableStyleProperties openXmlElement, DMW.StyleParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.StyleParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.StyleParagraphProperties>(), value, diffs, objName);
  }
  
  private static void SetStyleParagraphProperties(DXW.TableStyleProperties openXmlElement, DMW.StyleParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.StyleParagraphPropertiesConverter.CreateOpenXmlElement<DXW.StyleParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Table Style Conditional Formatting Run Properties conversion.
  private static DMW.TableStyleRunProperties? GetRunPropertiesBaseStyle(DXW.TableStyleProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunPropertiesBaseStyle>();
    if (element != null)
      return DMXW.BaseRunPropertiesConverter.CreateModelElement<DMW.TableStyleRunProperties>(element);
    return null;
  }
  
  private static bool CmpRunPropertiesBaseStyle(DXW.TableStyleProperties openXmlElement, DMW.TableStyleRunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.BaseRunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunPropertiesBaseStyle>(), value, diffs, objName);
  }
  
  private static void SetRunPropertiesBaseStyle(DXW.TableStyleProperties openXmlElement, DMW.TableStyleRunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunPropertiesBaseStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BaseRunPropertiesConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Table Style Conditional Formatting Table Properties conversion.
  private static DMW.TableStyleConditionalTableProperties? GetTableStyleConditionalFormattingTableProperties(DXW.TableStyleProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableStyleConditionalFormattingTableProperties>();
    if (element != null)
      return DMXW.TableStyleConditionalFormattingTablePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableStyleConditionalFormattingTableProperties(DXW.TableStyleProperties openXmlElement, DMW.TableStyleConditionalTableProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableStyleConditionalFormattingTablePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableProperties>(), value, diffs, objName);
  }
  
  private static void SetTableStyleConditionalFormattingTableProperties(DXW.TableStyleProperties openXmlElement, DMW.TableStyleConditionalTableProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableStyleConditionalFormattingTablePropertiesConverter.CreateOpenXmlElement<DXW.TableStyleConditionalFormattingTableProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Table Style Conditional Formatting Table Row Properties conversion.
  private static DMW.TableStyleConditionalRowProperties? GetTableStyleConditionalFormattingTableRowProperties(DXW.TableStyleProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>();
    if (element != null)
      return DMXW.TableStyleConditionalFormattingTableRowPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableStyleConditionalFormattingTableRowProperties(DXW.TableStyleProperties openXmlElement, DMW.TableStyleConditionalRowProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableStyleConditionalFormattingTableRowPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>(), value, diffs, objName);
  }
  
  private static void SetTableStyleConditionalFormattingTableRowProperties(DXW.TableStyleProperties openXmlElement, DMW.TableStyleConditionalRowProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableStyleConditionalFormattingTableRowPropertiesConverter.CreateOpenXmlElement<DXW.TableStyleConditionalFormattingTableRowProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Table Style Conditional Formatting Table Cell Properties conversion.
  private static DMW.TableStyleConditionalCellProperties? GetTableStyleConditionalFormattingTableCellProperties(DXW.TableStyleProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableStyleConditionalFormattingTableCellProperties>();
    if (element != null)
      return DMXW.TableStyleConditionalFormattingTableCellPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableStyleConditionalFormattingTableCellProperties(DXW.TableStyleProperties openXmlElement, DMW.TableStyleConditionalCellProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableStyleConditionalFormattingTableCellPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableCellProperties>(), value, diffs, objName);
  }
  
  private static void SetTableStyleConditionalFormattingTableCellProperties(DXW.TableStyleProperties openXmlElement, DMW.TableStyleConditionalCellProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableCellProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableStyleConditionalFormattingTableCellPropertiesConverter.CreateOpenXmlElement<DXW.TableStyleConditionalFormattingTableCellProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region TableStyleProperties model conversion.
  public static DMW.TableStyleProperties? CreateModelElement(DXW.TableStyleProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.TableStyleProperties();
      model.Type = GetType(openXmlElement);
      model.StyleParagraphProperties = GetStyleParagraphProperties(openXmlElement);
      model.TableStyleRunProperties = GetRunPropertiesBaseStyle(openXmlElement);
      model.TableStyleConditionalTableProperties = GetTableStyleConditionalFormattingTableProperties(openXmlElement);
      model.TableStyleConditionalRowProperties = GetTableStyleConditionalFormattingTableRowProperties(openXmlElement);
      model.TableStyleConditionalCellProperties = GetTableStyleConditionalFormattingTableCellProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableStyleProperties? openXmlElement, DMW.TableStyleProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, model.Type, diffs, objName))
        ok = false;
      if (!CmpStyleParagraphProperties(openXmlElement, model.StyleParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpRunPropertiesBaseStyle(openXmlElement, model.TableStyleRunProperties, diffs, objName))
        ok = false;
      if (!CmpTableStyleConditionalFormattingTableProperties(openXmlElement, model.TableStyleConditionalTableProperties, diffs, objName))
        ok = false;
      if (!CmpTableStyleConditionalFormattingTableRowProperties(openXmlElement, model.TableStyleConditionalRowProperties, diffs, objName))
        ok = false;
      if (!CmpTableStyleConditionalFormattingTableCellProperties(openXmlElement, model.TableStyleConditionalCellProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableStyleProperties model)
    where OpenXmlElementType: DXW.TableStyleProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableStyleProperties openXmlElement, DMW.TableStyleProperties model)
  {
    SetType(openXmlElement, model?.Type);
    SetStyleParagraphProperties(openXmlElement, model?.StyleParagraphProperties);
    SetRunPropertiesBaseStyle(openXmlElement, model?.TableStyleRunProperties);
    SetTableStyleConditionalFormattingTableProperties(openXmlElement, model?.TableStyleConditionalTableProperties);
    SetTableStyleConditionalFormattingTableRowProperties(openXmlElement, model?.TableStyleConditionalRowProperties);
    SetTableStyleConditionalFormattingTableCellProperties(openXmlElement, model?.TableStyleConditionalCellProperties);
  }
  #endregion
}
