namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Paragraph Properties.
/// </summary>
public static class ParagraphPropertiesConverter
{
  /// <summary>
  /// ParagraphStyleId.
  /// </summary>
  private static String? GetParagraphStyleId(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.ParagraphStyleId>()?.Val?.Value;
  }
  
  private static bool CmpParagraphStyleId(DXW.ParagraphProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphStyleId>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "ParagraphStyleId", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetParagraphStyleId(DXW.ParagraphProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphStyleId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.ParagraphStyleId { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// KeepNext.
  /// </summary>
  private static Boolean? GetKeepNext(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.KeepNext>()?.Val?.Value;
  }
  
  private static bool CmpKeepNext(DXW.ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.KeepNext>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.KeepNext", val, value);
    return false;
  }
  
  private static void SetKeepNext(DXW.ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.KeepNext>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.KeepNext();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// KeepLines.
  /// </summary>
  private static Boolean? GetKeepLines(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.KeepLines>()?.Val?.Value;
  }
  
  private static bool CmpKeepLines(DXW.ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.KeepLines>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.KeepLines", val, value);
    return false;
  }
  
  private static void SetKeepLines(DXW.ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.KeepLines>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.KeepLines();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PageBreakBefore.
  /// </summary>
  private static Boolean? GetPageBreakBefore(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.PageBreakBefore>()?.Val?.Value;
  }
  
  private static bool CmpPageBreakBefore(DXW.ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.PageBreakBefore>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.PageBreakBefore", val, value);
    return false;
  }
  
  private static void SetPageBreakBefore(DXW.ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.PageBreakBefore>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.PageBreakBefore();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FrameProperties.
  /// </summary>
  private static DMW.FrameProperties? GetFrameProperties(DXW.ParagraphProperties openXmlElement)
  {
    return DMXW.FramePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.FrameProperties>());
  }
  
  private static bool CmpFrameProperties(DXW.ParagraphProperties openXmlElement, DMW.FrameProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.FramePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.FrameProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFrameProperties(DXW.ParagraphProperties openXmlElement, DMW.FrameProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.FrameProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FramePropertiesConverter.CreateOpenXmlElement<DXW.FrameProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// WidowControl.
  /// </summary>
  private static Boolean? GetWidowControl(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.WidowControl>()?.Val?.Value;
  }
  
  private static bool CmpWidowControl(DXW.ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.WidowControl>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.WidowControl", val, value);
    return false;
  }
  
  private static void SetWidowControl(DXW.ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.WidowControl>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.WidowControl();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NumberingProperties.
  /// </summary>
  private static DMW.NumberingProperties? GetNumberingProperties(DXW.ParagraphProperties openXmlElement)
  {
    return DMXW.NumberingPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.NumberingProperties>());
  }
  
  private static bool CmpNumberingProperties(DXW.ParagraphProperties openXmlElement, DMW.NumberingProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.NumberingPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.NumberingProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberingProperties(DXW.ParagraphProperties openXmlElement, DMW.NumberingProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NumberingProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.NumberingPropertiesConverter.CreateOpenXmlElement<DXW.NumberingProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SuppressLineNumbers.
  /// </summary>
  private static Boolean? GetSuppressLineNumbers(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.SuppressLineNumbers>()?.Val?.Value;
  }
  
  private static bool CmpSuppressLineNumbers(DXW.ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.SuppressLineNumbers>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SuppressLineNumbers", val, value);
    return false;
  }
  
  private static void SetSuppressLineNumbers(DXW.ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SuppressLineNumbers>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SuppressLineNumbers();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ParagraphBorders.
  /// </summary>
  private static DMW.ParagraphBorders? GetParagraphBorders(DXW.ParagraphProperties openXmlElement)
  {
    return DMXW.ParagraphBordersConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.ParagraphBorders>());
  }
  
  private static bool CmpParagraphBorders(DXW.ParagraphProperties openXmlElement, DMW.ParagraphBorders? value, DiffList? diffs, string? objName)
  {
    return DMXW.ParagraphBordersConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ParagraphBorders>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetParagraphBorders(DXW.ParagraphProperties openXmlElement, DMW.ParagraphBorders? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphBorders>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ParagraphBordersConverter.CreateOpenXmlElement<DXW.ParagraphBorders>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  private static DMW.Shading? GetShading(DXW.ParagraphProperties openXmlElement)
  {
    return DMXW.ShadingConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Shading>());
  }
  
  private static bool CmpShading(DXW.ParagraphProperties openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Shading>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShading(DXW.ParagraphProperties openXmlElement, DMW.Shading? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Shading>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ShadingConverter.CreateOpenXmlElement<DXW.Shading>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  private static DMW.Tabs? GetTabs(DXW.ParagraphProperties openXmlElement)
  {
    return DMXW.TabsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Tabs>());
  }
  
  private static bool CmpTabs(DXW.ParagraphProperties openXmlElement, DMW.Tabs? value, DiffList? diffs, string? objName)
  {
    return DMXW.TabsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Tabs>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTabs(DXW.ParagraphProperties openXmlElement, DMW.Tabs? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Tabs>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TabsConverter.CreateOpenXmlElement<DXW.Tabs>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SuppressAutoHyphens.
  /// </summary>
  private static Boolean? GetSuppressAutoHyphens(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.SuppressAutoHyphens>()?.Val?.Value;
  }
  
  private static bool CmpSuppressAutoHyphens(DXW.ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.SuppressAutoHyphens>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SuppressAutoHyphens", val, value);
    return false;
  }
  
  private static void SetSuppressAutoHyphens(DXW.ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SuppressAutoHyphens>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SuppressAutoHyphens();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Kinsoku.
  /// </summary>
  private static Boolean? GetKinsoku(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.Kinsoku>()?.Val?.Value;
  }
  
  private static bool CmpKinsoku(DXW.ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.Kinsoku>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.Kinsoku", val, value);
    return false;
  }
  
  private static void SetKinsoku(DXW.ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Kinsoku>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Kinsoku();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// WordWrap.
  /// </summary>
  private static Boolean? GetWordWrap(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.WordWrap>()?.Val?.Value;
  }
  
  private static bool CmpWordWrap(DXW.ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.WordWrap>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.WordWrap", val, value);
    return false;
  }
  
  private static void SetWordWrap(DXW.ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.WordWrap>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.WordWrap();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OverflowPunctuation.
  /// </summary>
  private static Boolean? GetOverflowPunctuation(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.OverflowPunctuation>()?.Val?.Value;
  }
  
  private static bool CmpOverflowPunctuation(DXW.ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.OverflowPunctuation>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.OverflowPunctuation", val, value);
    return false;
  }
  
  private static void SetOverflowPunctuation(DXW.ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.OverflowPunctuation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.OverflowPunctuation();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TopLinePunctuation.
  /// </summary>
  private static Boolean? GetTopLinePunctuation(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.TopLinePunctuation>()?.Val?.Value;
  }
  
  private static bool CmpTopLinePunctuation(DXW.ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.TopLinePunctuation>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.TopLinePunctuation", val, value);
    return false;
  }
  
  private static void SetTopLinePunctuation(DXW.ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.TopLinePunctuation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.TopLinePunctuation();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// AutoSpaceDE.
  /// </summary>
  private static Boolean? GetAutoSpaceDE(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.AutoSpaceDE>()?.Val?.Value;
  }
  
  private static bool CmpAutoSpaceDE(DXW.ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.AutoSpaceDE>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.AutoSpaceDE", val, value);
    return false;
  }
  
  private static void SetAutoSpaceDE(DXW.ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AutoSpaceDE>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AutoSpaceDE();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// AutoSpaceDN.
  /// </summary>
  private static Boolean? GetAutoSpaceDN(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.AutoSpaceDN>()?.Val?.Value;
  }
  
  private static bool CmpAutoSpaceDN(DXW.ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.AutoSpaceDN>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.AutoSpaceDN", val, value);
    return false;
  }
  
  private static void SetAutoSpaceDN(DXW.ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AutoSpaceDN>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AutoSpaceDN();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// BiDi.
  /// </summary>
  private static Boolean? GetBiDi(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.BiDi>()?.Val?.Value;
  }
  
  private static bool CmpBiDi(DXW.ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.BiDi>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.BiDi", val, value);
    return false;
  }
  
  private static void SetBiDi(DXW.ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.BiDi>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.BiDi();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// AdjustRightIndent.
  /// </summary>
  private static Boolean? GetAdjustRightIndent(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.AdjustRightIndent>()?.Val?.Value;
  }
  
  private static bool CmpAdjustRightIndent(DXW.ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.AdjustRightIndent>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.AdjustRightIndent", val, value);
    return false;
  }
  
  private static void SetAdjustRightIndent(DXW.ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.AdjustRightIndent>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.AdjustRightIndent();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  private static Boolean? GetSnapToGrid(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.SnapToGrid>()?.Val?.Value;
  }
  
  private static bool CmpSnapToGrid(DXW.ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.SnapToGrid>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SnapToGrid", val, value);
    return false;
  }
  
  private static void SetSnapToGrid(DXW.ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SnapToGrid>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SnapToGrid();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SpacingBetweenLines.
  /// </summary>
  private static DMW.SpacingBetweenLines? GetSpacingBetweenLines(DXW.ParagraphProperties openXmlElement)
  {
    return DMXW.SpacingBetweenLinesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SpacingBetweenLines>());
  }
  
  private static bool CmpSpacingBetweenLines(DXW.ParagraphProperties openXmlElement, DMW.SpacingBetweenLines? value, DiffList? diffs, string? objName)
  {
    return DMXW.SpacingBetweenLinesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SpacingBetweenLines>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSpacingBetweenLines(DXW.ParagraphProperties openXmlElement, DMW.SpacingBetweenLines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SpacingBetweenLines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SpacingBetweenLinesConverter.CreateOpenXmlElement<DXW.SpacingBetweenLines>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Indentation.
  /// </summary>
  private static DMW.Indentation? GetIndentation(DXW.ParagraphProperties openXmlElement)
  {
    return DMXW.IndentationConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.Indentation>());
  }
  
  private static bool CmpIndentation(DXW.ParagraphProperties openXmlElement, DMW.Indentation? value, DiffList? diffs, string? objName)
  {
    return DMXW.IndentationConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Indentation>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetIndentation(DXW.ParagraphProperties openXmlElement, DMW.Indentation? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Indentation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.IndentationConverter.CreateOpenXmlElement<DXW.Indentation>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ContextualSpacing.
  /// </summary>
  private static Boolean? GetContextualSpacing(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.ContextualSpacing>()?.Val?.Value;
  }
  
  private static bool CmpContextualSpacing(DXW.ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.ContextualSpacing>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.ContextualSpacing", val, value);
    return false;
  }
  
  private static void SetContextualSpacing(DXW.ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.ContextualSpacing>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.ContextualSpacing();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// MirrorIndents.
  /// </summary>
  private static Boolean? GetMirrorIndents(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.MirrorIndents>()?.Val?.Value;
  }
  
  private static bool CmpMirrorIndents(DXW.ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.MirrorIndents>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.MirrorIndents", val, value);
    return false;
  }
  
  private static void SetMirrorIndents(DXW.ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.MirrorIndents>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.MirrorIndents();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SuppressOverlap.
  /// </summary>
  private static Boolean? GetSuppressOverlap(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.SuppressOverlap>()?.Val?.Value;
  }
  
  private static bool CmpSuppressOverlap(DXW.ParagraphProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXW.SuppressOverlap>()?.Val?.Value;
    if (val == value) return true;
    diffs?.Add(objName, "DXW.SuppressOverlap", val, value);
    return false;
  }
  
  private static void SetSuppressOverlap(DXW.ParagraphProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SuppressOverlap>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SuppressOverlap();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Justification.
  /// </summary>
  private static DMW.JustificationKind? GetJustification(DXW.ParagraphProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.JustificationValues, DMW.JustificationKind>(openXmlElement.GetFirstChild<DXW.Justification>()?.Val?.Value);
  }
  
  private static bool CmpJustification(DXW.ParagraphProperties openXmlElement, DMW.JustificationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.JustificationValues, DMW.JustificationKind>(openXmlElement.GetFirstChild<DXW.Justification>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetJustification(DXW.ParagraphProperties openXmlElement, DMW.JustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Justification>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.Justification, DocumentFormat.OpenXml.Wordprocessing.JustificationValues, DMW.JustificationKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextDirection.
  /// </summary>
  private static DMW.TextDirectionKind? GetTextDirection(DXW.ParagraphProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value);
  }
  
  private static bool CmpTextDirection(DXW.ParagraphProperties openXmlElement, DMW.TextDirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextDirection(DXW.ParagraphProperties openXmlElement, DMW.TextDirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextDirection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TextDirection, DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextAlignment.
  /// </summary>
  private static DMW.VerticalTextAlignmentKind? GetTextAlignment(DXW.ParagraphProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues, DMW.VerticalTextAlignmentKind>(openXmlElement.GetFirstChild<DXW.TextAlignment>()?.Val?.Value);
  }
  
  private static bool CmpTextAlignment(DXW.ParagraphProperties openXmlElement, DMW.VerticalTextAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues, DMW.VerticalTextAlignmentKind>(openXmlElement.GetFirstChild<DXW.TextAlignment>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextAlignment(DXW.ParagraphProperties openXmlElement, DMW.VerticalTextAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextAlignment>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TextAlignment, DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues, DMW.VerticalTextAlignmentKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TextBoxTightWrap.
  /// </summary>
  private static DMW.TextBoxTightWrapKind? GetTextBoxTightWrap(DXW.ParagraphProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues, DMW.TextBoxTightWrapKind>(openXmlElement.GetFirstChild<DXW.TextBoxTightWrap>()?.Val?.Value);
  }
  
  private static bool CmpTextBoxTightWrap(DXW.ParagraphProperties openXmlElement, DMW.TextBoxTightWrapKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues, DMW.TextBoxTightWrapKind>(openXmlElement.GetFirstChild<DXW.TextBoxTightWrap>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextBoxTightWrap(DXW.ParagraphProperties openXmlElement, DMW.TextBoxTightWrapKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextBoxTightWrap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TextBoxTightWrap, DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues, DMW.TextBoxTightWrapKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OutlineLevel.
  /// </summary>
  private static Int32? GetOutlineLevel(DXW.ParagraphProperties openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXW.OutlineLevel>()?.Val?.Value;
  }
  
  private static bool CmpOutlineLevel(DXW.ParagraphProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.OutlineLevel>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.OutlineLevel", itemElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetOutlineLevel(DXW.ParagraphProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.OutlineLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.OutlineLevel{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DivId.
  /// </summary>
  private static String? GetDivId(DXW.ParagraphProperties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXW.DivId>()?.Val?.Value;
  }
  
  private static bool CmpDivId(DXW.ParagraphProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXW.DivId>()?.Val?.Value == value;
  }
  
  private static void SetDivId(DXW.ParagraphProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DivId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DivId { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ConditionalFormatStyle.
  /// </summary>
  private static DMW.ConditionalFormatStyle? GetConditionalFormatStyle(DXW.ParagraphProperties openXmlElement)
  {
    return DMXW.ConditionalFormatStyleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.ConditionalFormatStyle>());
  }
  
  private static bool CmpConditionalFormatStyle(DXW.ParagraphProperties openXmlElement, DMW.ConditionalFormatStyle? value, DiffList? diffs, string? objName)
  {
    return DMXW.ConditionalFormatStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ConditionalFormatStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetConditionalFormatStyle(DXW.ParagraphProperties openXmlElement, DMW.ConditionalFormatStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ConditionalFormatStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ConditionalFormatStyleConverter.CreateOpenXmlElement<DXW.ConditionalFormatStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Run Properties for the Paragraph Mark.
  /// </summary>
  private static DMW.ParagraphMarkRunProperties? GetParagraphMarkRunProperties(DXW.ParagraphProperties openXmlElement)
  {
    return DMXW.ParagraphMarkRunPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.ParagraphMarkRunProperties>());
  }
  
  private static bool CmpParagraphMarkRunProperties(DXW.ParagraphProperties openXmlElement, DMW.ParagraphMarkRunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.ParagraphMarkRunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ParagraphMarkRunProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetParagraphMarkRunProperties(DXW.ParagraphProperties openXmlElement, DMW.ParagraphMarkRunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphMarkRunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ParagraphMarkRunPropertiesConverter.CreateOpenXmlElement<DXW.ParagraphMarkRunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Section Properties.
  /// </summary>
  private static DMW.SectionProperties? GetSectionProperties(DXW.ParagraphProperties openXmlElement)
  {
    return DMXW.SectionPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SectionProperties>());
  }
  
  private static bool CmpSectionProperties(DXW.ParagraphProperties openXmlElement, DMW.SectionProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.SectionPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SectionProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSectionProperties(DXW.ParagraphProperties openXmlElement, DMW.SectionProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SectionProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SectionPropertiesConverter.CreateOpenXmlElement<DXW.SectionProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ParagraphPropertiesChange.
  /// </summary>
  private static DMW.ParagraphPropertiesChange? GetParagraphPropertiesChange(DXW.ParagraphProperties openXmlElement)
  {
    return DMXW.ParagraphPropertiesChangeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.ParagraphPropertiesChange>());
  }
  
  private static bool CmpParagraphPropertiesChange(DXW.ParagraphProperties openXmlElement, DMW.ParagraphPropertiesChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.ParagraphPropertiesChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ParagraphPropertiesChange>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetParagraphPropertiesChange(DXW.ParagraphProperties openXmlElement, DMW.ParagraphPropertiesChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphPropertiesChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ParagraphPropertiesChangeConverter.CreateOpenXmlElement<DXW.ParagraphPropertiesChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.ParagraphProperties? CreateModelElement(DXW.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ParagraphProperties();
      value.ParagraphStyleId = GetParagraphStyleId(openXmlElement);
      value.KeepNext = GetKeepNext(openXmlElement);
      value.KeepLines = GetKeepLines(openXmlElement);
      value.PageBreakBefore = GetPageBreakBefore(openXmlElement);
      value.FrameProperties = GetFrameProperties(openXmlElement);
      value.WidowControl = GetWidowControl(openXmlElement);
      value.NumberingProperties = GetNumberingProperties(openXmlElement);
      value.SuppressLineNumbers = GetSuppressLineNumbers(openXmlElement);
      value.ParagraphBorders = GetParagraphBorders(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.Tabs = GetTabs(openXmlElement);
      value.SuppressAutoHyphens = GetSuppressAutoHyphens(openXmlElement);
      value.Kinsoku = GetKinsoku(openXmlElement);
      value.WordWrap = GetWordWrap(openXmlElement);
      value.OverflowPunctuation = GetOverflowPunctuation(openXmlElement);
      value.TopLinePunctuation = GetTopLinePunctuation(openXmlElement);
      value.AutoSpaceDE = GetAutoSpaceDE(openXmlElement);
      value.AutoSpaceDN = GetAutoSpaceDN(openXmlElement);
      value.BiDi = GetBiDi(openXmlElement);
      value.AdjustRightIndent = GetAdjustRightIndent(openXmlElement);
      value.SnapToGrid = GetSnapToGrid(openXmlElement);
      value.SpacingBetweenLines = GetSpacingBetweenLines(openXmlElement);
      value.Indentation = GetIndentation(openXmlElement);
      value.ContextualSpacing = GetContextualSpacing(openXmlElement);
      value.MirrorIndents = GetMirrorIndents(openXmlElement);
      value.SuppressOverlap = GetSuppressOverlap(openXmlElement);
      value.Justification = GetJustification(openXmlElement);
      value.TextDirection = GetTextDirection(openXmlElement);
      value.TextAlignment = GetTextAlignment(openXmlElement);
      value.TextBoxTightWrap = GetTextBoxTightWrap(openXmlElement);
      value.OutlineLevel = GetOutlineLevel(openXmlElement);
      value.DivId = GetDivId(openXmlElement);
      value.ConditionalFormatStyle = GetConditionalFormatStyle(openXmlElement);
      value.ParagraphMarkRunProperties = GetParagraphMarkRunProperties(openXmlElement);
      value.SectionProperties = GetSectionProperties(openXmlElement);
      value.ParagraphPropertiesChange = GetParagraphPropertiesChange(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ParagraphProperties? openXmlElement, DMW.ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpParagraphStyleId(openXmlElement, value.ParagraphStyleId, diffs, objName))
        ok = false;
      if (!CmpKeepNext(openXmlElement, value.KeepNext, diffs, objName))
        ok = false;
      if (!CmpKeepLines(openXmlElement, value.KeepLines, diffs, objName))
        ok = false;
      if (!CmpPageBreakBefore(openXmlElement, value.PageBreakBefore, diffs, objName))
        ok = false;
      if (!CmpFrameProperties(openXmlElement, value.FrameProperties, diffs, objName))
        ok = false;
      if (!CmpWidowControl(openXmlElement, value.WidowControl, diffs, objName))
        ok = false;
      if (!CmpNumberingProperties(openXmlElement, value.NumberingProperties, diffs, objName))
        ok = false;
      if (!CmpSuppressLineNumbers(openXmlElement, value.SuppressLineNumbers, diffs, objName))
        ok = false;
      if (!CmpParagraphBorders(openXmlElement, value.ParagraphBorders, diffs, objName))
        ok = false;
      if (!CmpShading(openXmlElement, value.Shading, diffs, objName))
        ok = false;
      if (!CmpTabs(openXmlElement, value.Tabs, diffs, objName))
        ok = false;
      if (!CmpSuppressAutoHyphens(openXmlElement, value.SuppressAutoHyphens, diffs, objName))
        ok = false;
      if (!CmpKinsoku(openXmlElement, value.Kinsoku, diffs, objName))
        ok = false;
      if (!CmpWordWrap(openXmlElement, value.WordWrap, diffs, objName))
        ok = false;
      if (!CmpOverflowPunctuation(openXmlElement, value.OverflowPunctuation, diffs, objName))
        ok = false;
      if (!CmpTopLinePunctuation(openXmlElement, value.TopLinePunctuation, diffs, objName))
        ok = false;
      if (!CmpAutoSpaceDE(openXmlElement, value.AutoSpaceDE, diffs, objName))
        ok = false;
      if (!CmpAutoSpaceDN(openXmlElement, value.AutoSpaceDN, diffs, objName))
        ok = false;
      if (!CmpBiDi(openXmlElement, value.BiDi, diffs, objName))
        ok = false;
      if (!CmpAdjustRightIndent(openXmlElement, value.AdjustRightIndent, diffs, objName))
        ok = false;
      if (!CmpSnapToGrid(openXmlElement, value.SnapToGrid, diffs, objName))
        ok = false;
      if (!CmpSpacingBetweenLines(openXmlElement, value.SpacingBetweenLines, diffs, objName))
        ok = false;
      if (!CmpIndentation(openXmlElement, value.Indentation, diffs, objName))
        ok = false;
      if (!CmpContextualSpacing(openXmlElement, value.ContextualSpacing, diffs, objName))
        ok = false;
      if (!CmpMirrorIndents(openXmlElement, value.MirrorIndents, diffs, objName))
        ok = false;
      if (!CmpSuppressOverlap(openXmlElement, value.SuppressOverlap, diffs, objName))
        ok = false;
      if (!CmpJustification(openXmlElement, value.Justification, diffs, objName))
        ok = false;
      if (!CmpTextDirection(openXmlElement, value.TextDirection, diffs, objName))
        ok = false;
      if (!CmpTextAlignment(openXmlElement, value.TextAlignment, diffs, objName))
        ok = false;
      if (!CmpTextBoxTightWrap(openXmlElement, value.TextBoxTightWrap, diffs, objName))
        ok = false;
      if (!CmpOutlineLevel(openXmlElement, value.OutlineLevel, diffs, objName))
        ok = false;
      if (!CmpDivId(openXmlElement, value.DivId, diffs, objName))
        ok = false;
      if (!CmpConditionalFormatStyle(openXmlElement, value.ConditionalFormatStyle, diffs, objName))
        ok = false;
      if (!CmpParagraphMarkRunProperties(openXmlElement, value.ParagraphMarkRunProperties, diffs, objName))
        ok = false;
      if (!CmpSectionProperties(openXmlElement, value.SectionProperties, diffs, objName))
        ok = false;
      if (!CmpParagraphPropertiesChange(openXmlElement, value.ParagraphPropertiesChange, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ParagraphProperties? value)
    where OpenXmlElementType: DXW.ParagraphProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParagraphStyleId(openXmlElement, value?.ParagraphStyleId);
      SetKeepNext(openXmlElement, value?.KeepNext);
      SetKeepLines(openXmlElement, value?.KeepLines);
      SetPageBreakBefore(openXmlElement, value?.PageBreakBefore);
      SetFrameProperties(openXmlElement, value?.FrameProperties);
      SetWidowControl(openXmlElement, value?.WidowControl);
      SetNumberingProperties(openXmlElement, value?.NumberingProperties);
      SetSuppressLineNumbers(openXmlElement, value?.SuppressLineNumbers);
      SetParagraphBorders(openXmlElement, value?.ParagraphBorders);
      SetShading(openXmlElement, value?.Shading);
      SetTabs(openXmlElement, value?.Tabs);
      SetSuppressAutoHyphens(openXmlElement, value?.SuppressAutoHyphens);
      SetKinsoku(openXmlElement, value?.Kinsoku);
      SetWordWrap(openXmlElement, value?.WordWrap);
      SetOverflowPunctuation(openXmlElement, value?.OverflowPunctuation);
      SetTopLinePunctuation(openXmlElement, value?.TopLinePunctuation);
      SetAutoSpaceDE(openXmlElement, value?.AutoSpaceDE);
      SetAutoSpaceDN(openXmlElement, value?.AutoSpaceDN);
      SetBiDi(openXmlElement, value?.BiDi);
      SetAdjustRightIndent(openXmlElement, value?.AdjustRightIndent);
      SetSnapToGrid(openXmlElement, value?.SnapToGrid);
      SetSpacingBetweenLines(openXmlElement, value?.SpacingBetweenLines);
      SetIndentation(openXmlElement, value?.Indentation);
      SetContextualSpacing(openXmlElement, value?.ContextualSpacing);
      SetMirrorIndents(openXmlElement, value?.MirrorIndents);
      SetSuppressOverlap(openXmlElement, value?.SuppressOverlap);
      SetJustification(openXmlElement, value?.Justification);
      SetTextDirection(openXmlElement, value?.TextDirection);
      SetTextAlignment(openXmlElement, value?.TextAlignment);
      SetTextBoxTightWrap(openXmlElement, value?.TextBoxTightWrap);
      SetOutlineLevel(openXmlElement, value?.OutlineLevel);
      SetDivId(openXmlElement, value?.DivId);
      SetConditionalFormatStyle(openXmlElement, value?.ConditionalFormatStyle);
      SetParagraphMarkRunProperties(openXmlElement, value?.ParagraphMarkRunProperties);
      SetSectionProperties(openXmlElement, value?.SectionProperties);
      SetParagraphPropertiesChange(openXmlElement, value?.ParagraphPropertiesChange);
      return openXmlElement;
    }
    return default;
  }
}
