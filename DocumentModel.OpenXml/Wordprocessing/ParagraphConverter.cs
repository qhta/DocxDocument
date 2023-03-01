namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Body class converter betweeen 
/// DocumentFormat.OpenXml.Wordprocessing and DMW namespaces.
/// </summary>
public static class ParagraphConverter
{
  /// <summary>
  /// Revision Identifier for Paragraph Glyph Formatting
  /// </summary>
  private static DM.HexInt? GetRsidParagraphMarkRevision(DXW.Paragraph openXmlElement)
  {
    if (openXmlElement?.RsidParagraphMarkRevision?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidParagraphMarkRevision.Value);
    return null;
  }

  private static bool CmpRsidParagraphMarkRevision(DXW.Paragraph openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidParagraphMarkRevision?.Value, value, diffs, objName, "RsidParagraphMarkRevision");
  }

  private static void SetRsidParagraphMarkRevision(DXW.Paragraph openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidParagraphMarkRevision = value.ToString();
    else
      openXmlElement.RsidParagraphMarkRevision = null;
  }

  /// <summary>
  /// Revision Identifier for Paragraph
  /// </summary>
  private static DM.HexInt? GetRsidParagraphAddition(DXW.Paragraph openXmlElement)
  {
    if (openXmlElement?.RsidParagraphAddition?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidParagraphAddition.Value);
    return null;
  }

  private static bool CmpRsidParagraphAddition(DXW.Paragraph openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidParagraphAddition?.Value, value, diffs, objName, "RsidParagraphAddition");
  }

  private static void SetRsidParagraphAddition(DXW.Paragraph openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidParagraphAddition = value.ToString();
    else
      openXmlElement.RsidParagraphAddition = null;
  }

  /// <summary>
  /// Revision Identifier for Paragraph Deletion
  /// </summary>
  private static DM.HexInt? GetRsidParagraphDeletion(DXW.Paragraph openXmlElement)
  {
    if (openXmlElement?.RsidParagraphDeletion?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidParagraphDeletion.Value);
    return null;
  }

  private static bool CmpRsidParagraphDeletion(DXW.Paragraph openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidParagraphDeletion?.Value, value, diffs, objName, "RsidParagraphDeletion");
  }

  private static void SetRsidParagraphDeletion(DXW.Paragraph openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidParagraphDeletion = value.ToString();
    else
      openXmlElement.RsidParagraphDeletion = null;
  }

  /// <summary>
  /// Revision Identifier for Paragraph Properties
  /// </summary>
  private static DM.HexInt? GetRsidParagraphProperties(DXW.Paragraph openXmlElement)
  {
    if (openXmlElement?.RsidParagraphProperties?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidParagraphProperties.Value);
    return null;
  }

  private static bool CmpRsidParagraphProperties(DXW.Paragraph openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidParagraphProperties?.Value, value, diffs, objName, "RsidParagraphProperties");
  }

  private static void SetRsidParagraphProperties(DXW.Paragraph openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidParagraphProperties = value.ToString();
    else
      openXmlElement.RsidParagraphProperties = null;
  }

  /// <summary>
  /// Default Revision Identifier for Runs
  /// </summary>
  private static DM.HexInt? GetRsidRunAdditionDefault(DXW.Paragraph openXmlElement)
  {
    if (openXmlElement?.RsidRunAdditionDefault?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidRunAdditionDefault.Value);
    return null;
  }

  private static bool CmpRsidRunAdditionDefault(DXW.Paragraph openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidRunAdditionDefault?.Value, value, diffs, objName, "RsidRunAdditionDefault");
  }

  private static void SetRsidRunAdditionDefault(DXW.Paragraph openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidRunAdditionDefault = value.ToString();
    else
      openXmlElement.RsidRunAdditionDefault = null;
  }

  /// <summary>
  /// paraId, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.HexInt? GetParagraphId(DXW.Paragraph openXmlElement)
  {
    if (openXmlElement?.ParagraphId?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.ParagraphId.Value);
    return null;
  }

  private static bool CmpParagraphId(DXW.Paragraph openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.ParagraphId?.Value, value, diffs, objName, "ParagraphId");
  }

  private static void SetParagraphId(DXW.Paragraph openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.ParagraphId = value.ToString();
    else
      openXmlElement.ParagraphId = null;
  }

  /// <summary>
  /// textId, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.HexInt? GetTextId(DXW.Paragraph openXmlElement)
  {
    if (openXmlElement?.TextId?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.TextId.Value);
    return null;
  }

  private static bool CmpTextId(DXW.Paragraph openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.TextId?.Value, value, diffs, objName, "TextId");
  }

  private static void SetTextId(DXW.Paragraph openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.TextId = value.ToString();
    else
      openXmlElement.TextId = null;
  }

  /// <summary>
  /// Paragraph Properties.
  /// </summary>
  private static DMW.ParagraphProperties? GetParagraphProperties(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ParagraphProperties>();
    if (element != null)
      return DMXW.ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpParagraphProperties(DXW.Paragraph openXmlElement, DMW.ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ParagraphProperties>(), value, diffs, objName?.Concat2(".", openXmlElement?.GetType().Name));
  }

  private static void SetParagraphProperties(DXW.Paragraph openXmlElement, DMW.ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ParagraphPropertiesConverter.CreateOpenXmlElement<DXW.ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  /*
  /// <summary>
  /// noSpellErr, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetNoSpellError(DXW.Paragraph openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.NoSpellError);
  }
  
  private static bool CmpNoSpellError(DXW.Paragraph openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.NoSpellError, value, diffs, objName, "NoSpellError");
  }
  
  private static void SetNoSpellError(DXW.Paragraph openXmlElement, Boolean? value)
  {
    openXmlElement.NoSpellError = BooleanValueConverter.CreateOnOffValue(value);
  }
  

  private static DMW.CustomXmlRun? GetCustomXmlRun(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlRun>();
    if (element != null)
      return DMXW.CustomXmlRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlRun(DXW.Paragraph openXmlElement, DMW.CustomXmlRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.CustomXmlRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlRun>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlRun(DXW.Paragraph openXmlElement, DMW.CustomXmlRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CustomXmlRunConverter.CreateOpenXmlElement<DXW.CustomXmlRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMW.SimpleField>? GetSimpleFields(DXW.Paragraph openXmlElement)
  {
    var collection = new Collection<DMW.SimpleField>();
    foreach (var item in openXmlElement.Elements<DXW.SimpleField>())
    {
      var newItem = DMXW.SimpleFieldConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSimpleFields(DXW.Paragraph openXmlElement, Collection<DMW.SimpleField>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.SimpleField>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.SimpleFieldConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSimpleFields(DXW.Paragraph openXmlElement, Collection<DMW.SimpleField>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.SimpleField>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.SimpleFieldConverter.CreateOpenXmlElement<DXW.SimpleField>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMW.Hyperlink? GetHyperlink(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Hyperlink>();
    if (element != null)
      return DMXW.HyperlinkConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlink(DXW.Paragraph openXmlElement, DMW.Hyperlink? value, DiffList? diffs, string? objName)
  {
    return DMXW.HyperlinkConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Hyperlink>(), value, diffs, objName);
  }
  
  private static void SetHyperlink(DXW.Paragraph openXmlElement, DMW.Hyperlink? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Hyperlink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.HyperlinkConverter.CreateOpenXmlElement<DXW.Hyperlink>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtRun? GetSdtRun(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SdtRun>();
    if (element != null)
      return DMXW.SdtRunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSdtRun(DXW.Paragraph openXmlElement, DMW.SdtRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtRun>(), value, diffs, objName);
  }
  
  private static void SetSdtRun(DXW.Paragraph openXmlElement, DMW.SdtRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtRunConverter.CreateOpenXmlElement<DXW.SdtRun>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
 

  
  private static DMMath.Paragraph? GetChildParagraph(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Paragraph>();
    if (element != null)
      return DMXMath.ParagraphConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildParagraph(DXW.Paragraph openXmlElement, DMMath.Paragraph? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ParagraphConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Paragraph>(), value, diffs, objName);
  }
  
  private static void SetChildParagraph(DXW.Paragraph openXmlElement, DMMath.Paragraph? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Paragraph>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.ParagraphConverter.CreateOpenXmlElement<DXMath.Paragraph>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.OfficeMath? GetOfficeMath(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.OfficeMath>();
    if (element != null)
      return DMXMath.OfficeMathConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeMath(DXW.Paragraph openXmlElement, DMMath.OfficeMath? value, DiffList? diffs, string? objName)
  {
    return DMXMath.OfficeMathConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.OfficeMath>(), value, diffs, objName);
  }
  
  private static void SetOfficeMath(DXW.Paragraph openXmlElement, DMMath.OfficeMath? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.OfficeMath>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.OfficeMathConverter.CreateOpenXmlElement<DXMath.OfficeMath>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Accent? GetAccent(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Accent>();
    if (element != null)
      return DMXMath.AccentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAccent(DXW.Paragraph openXmlElement, DMMath.Accent? value, DiffList? diffs, string? objName)
  {
    return DMXMath.AccentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Accent>(), value, diffs, objName);
  }
  
  private static void SetAccent(DXW.Paragraph openXmlElement, DMMath.Accent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Accent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.AccentConverter.CreateOpenXmlElement<DXMath.Accent>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Bar? GetBar(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Bar>();
    if (element != null)
      return DMXMath.BarConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBar(DXW.Paragraph openXmlElement, DMMath.Bar? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BarConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Bar>(), value, diffs, objName);
  }
  
  private static void SetBar(DXW.Paragraph openXmlElement, DMMath.Bar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Bar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BarConverter.CreateOpenXmlElement<DXMath.Bar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Box? GetBox(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Box>();
    if (element != null)
      return DMXMath.BoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBox(DXW.Paragraph openXmlElement, DMMath.Box? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Box>(), value, diffs, objName);
  }
  
  private static void SetBox(DXW.Paragraph openXmlElement, DMMath.Box? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Box>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BoxConverter.CreateOpenXmlElement<DXMath.Box>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.BorderBox? GetBorderBox(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.BorderBox>();
    if (element != null)
      return DMXMath.BorderBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBorderBox(DXW.Paragraph openXmlElement, DMMath.BorderBox? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BorderBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.BorderBox>(), value, diffs, objName);
  }
  
  private static void SetBorderBox(DXW.Paragraph openXmlElement, DMMath.BorderBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.BorderBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BorderBoxConverter.CreateOpenXmlElement<DXMath.BorderBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Delimiter? GetDelimiter(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Delimiter>();
    if (element != null)
      return DMXMath.DelimiterConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDelimiter(DXW.Paragraph openXmlElement, DMMath.Delimiter? value, DiffList? diffs, string? objName)
  {
    return DMXMath.DelimiterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Delimiter>(), value, diffs, objName);
  }
  
  private static void SetDelimiter(DXW.Paragraph openXmlElement, DMMath.Delimiter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Delimiter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.DelimiterConverter.CreateOpenXmlElement<DXMath.Delimiter>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.EquationArray? GetEquationArray(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.EquationArray>();
    if (element != null)
      return DMXMath.EquationArrayConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEquationArray(DXW.Paragraph openXmlElement, DMMath.EquationArray? value, DiffList? diffs, string? objName)
  {
    return DMXMath.EquationArrayConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.EquationArray>(), value, diffs, objName);
  }
  
  private static void SetEquationArray(DXW.Paragraph openXmlElement, DMMath.EquationArray? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.EquationArray>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.EquationArrayConverter.CreateOpenXmlElement<DXMath.EquationArray>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Fraction? GetFraction(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Fraction>();
    if (element != null)
      return DMXMath.FractionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFraction(DXW.Paragraph openXmlElement, DMMath.Fraction? value, DiffList? diffs, string? objName)
  {
    return DMXMath.FractionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Fraction>(), value, diffs, objName);
  }
  
  private static void SetFraction(DXW.Paragraph openXmlElement, DMMath.Fraction? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Fraction>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.FractionConverter.CreateOpenXmlElement<DXMath.Fraction>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.MathFunction? GetMathFunction(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.MathFunction>();
    if (element != null)
      return DMXMath.MathFunctionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMathFunction(DXW.Paragraph openXmlElement, DMMath.MathFunction? value, DiffList? diffs, string? objName)
  {
    return DMXMath.MathFunctionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.MathFunction>(), value, diffs, objName);
  }
  
  private static void SetMathFunction(DXW.Paragraph openXmlElement, DMMath.MathFunction? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.MathFunction>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.MathFunctionConverter.CreateOpenXmlElement<DXMath.MathFunction>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.GroupChar? GetGroupChar(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.GroupChar>();
    if (element != null)
      return DMXMath.GroupCharConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupChar(DXW.Paragraph openXmlElement, DMMath.GroupChar? value, DiffList? diffs, string? objName)
  {
    return DMXMath.GroupCharConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.GroupChar>(), value, diffs, objName);
  }
  
  private static void SetGroupChar(DXW.Paragraph openXmlElement, DMMath.GroupChar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.GroupChar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.GroupCharConverter.CreateOpenXmlElement<DXMath.GroupChar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.LimitLower? GetLimitLower(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.LimitLower>();
    if (element != null)
      return DMXMath.LimitLowerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLimitLower(DXW.Paragraph openXmlElement, DMMath.LimitLower? value, DiffList? diffs, string? objName)
  {
    return DMXMath.LimitLowerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.LimitLower>(), value, diffs, objName);
  }
  
  private static void SetLimitLower(DXW.Paragraph openXmlElement, DMMath.LimitLower? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.LimitLower>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.LimitLowerConverter.CreateOpenXmlElement<DXMath.LimitLower>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.LimitUpper? GetLimitUpper(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.LimitUpper>();
    if (element != null)
      return DMXMath.LimitUpperConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLimitUpper(DXW.Paragraph openXmlElement, DMMath.LimitUpper? value, DiffList? diffs, string? objName)
  {
    return DMXMath.LimitUpperConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.LimitUpper>(), value, diffs, objName);
  }
  
  private static void SetLimitUpper(DXW.Paragraph openXmlElement, DMMath.LimitUpper? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.LimitUpper>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.LimitUpperConverter.CreateOpenXmlElement<DXMath.LimitUpper>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Matrix? GetMatrix(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Matrix>();
    if (element != null)
      return DMXMath.MatrixConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMatrix(DXW.Paragraph openXmlElement, DMMath.Matrix? value, DiffList? diffs, string? objName)
  {
    return DMXMath.MatrixConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Matrix>(), value, diffs, objName);
  }
  
  private static void SetMatrix(DXW.Paragraph openXmlElement, DMMath.Matrix? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Matrix>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.MatrixConverter.CreateOpenXmlElement<DXMath.Matrix>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Nary? GetNary(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Nary>();
    if (element != null)
      return DMXMath.NaryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNary(DXW.Paragraph openXmlElement, DMMath.Nary? value, DiffList? diffs, string? objName)
  {
    return DMXMath.NaryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Nary>(), value, diffs, objName);
  }
  
  private static void SetNary(DXW.Paragraph openXmlElement, DMMath.Nary? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Nary>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.NaryConverter.CreateOpenXmlElement<DXMath.Nary>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Phantom? GetPhantom(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Phantom>();
    if (element != null)
      return DMXMath.PhantomConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPhantom(DXW.Paragraph openXmlElement, DMMath.Phantom? value, DiffList? diffs, string? objName)
  {
    return DMXMath.PhantomConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Phantom>(), value, diffs, objName);
  }
  
  private static void SetPhantom(DXW.Paragraph openXmlElement, DMMath.Phantom? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Phantom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.PhantomConverter.CreateOpenXmlElement<DXMath.Phantom>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Radical? GetRadical(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Radical>();
    if (element != null)
      return DMXMath.RadicalConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRadical(DXW.Paragraph openXmlElement, DMMath.Radical? value, DiffList? diffs, string? objName)
  {
    return DMXMath.RadicalConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Radical>(), value, diffs, objName);
  }
  
  private static void SetRadical(DXW.Paragraph openXmlElement, DMMath.Radical? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Radical>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.RadicalConverter.CreateOpenXmlElement<DXMath.Radical>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.PreSubSuper? GetPreSubSuper(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.PreSubSuper>();
    if (element != null)
      return DMXMath.PreSubSuperConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreSubSuper(DXW.Paragraph openXmlElement, DMMath.PreSubSuper? value, DiffList? diffs, string? objName)
  {
    return DMXMath.PreSubSuperConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.PreSubSuper>(), value, diffs, objName);
  }
  
  private static void SetPreSubSuper(DXW.Paragraph openXmlElement, DMMath.PreSubSuper? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.PreSubSuper>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.PreSubSuperConverter.CreateOpenXmlElement<DXMath.PreSubSuper>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Subscript? GetSubscript(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Subscript>();
    if (element != null)
      return DMXMath.SubscriptConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubscript(DXW.Paragraph openXmlElement, DMMath.Subscript? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubscriptConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Subscript>(), value, diffs, objName);
  }
  
  private static void SetSubscript(DXW.Paragraph openXmlElement, DMMath.Subscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Subscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SubscriptConverter.CreateOpenXmlElement<DXMath.Subscript>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.SubSuperscript? GetSubSuperscript(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.SubSuperscript>();
    if (element != null)
      return DMXMath.SubSuperscriptConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubSuperscript(DXW.Paragraph openXmlElement, DMMath.SubSuperscript? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubSuperscriptConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.SubSuperscript>(), value, diffs, objName);
  }
  
  private static void SetSubSuperscript(DXW.Paragraph openXmlElement, DMMath.SubSuperscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.SubSuperscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SubSuperscriptConverter.CreateOpenXmlElement<DXMath.SubSuperscript>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Superscript? GetSuperscript(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Superscript>();
    if (element != null)
      return DMXMath.SuperscriptConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSuperscript(DXW.Paragraph openXmlElement, DMMath.Superscript? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SuperscriptConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Superscript>(), value, diffs, objName);
  }
  
  private static void SetSuperscript(DXW.Paragraph openXmlElement, DMMath.Superscript? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Superscript>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SuperscriptConverter.CreateOpenXmlElement<DXMath.Superscript>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMMath.Run? GetRun(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Run>();
    if (element != null)
      return DMXMath.RunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRun(DXW.Paragraph openXmlElement, DMMath.Run? value, DiffList? diffs, string? objName)
  {
    return DMXMath.RunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Run>(), value, diffs, objName);
  }
  
  private static void SetRun(DXW.Paragraph openXmlElement, DMMath.Run? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Run>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.RunConverter.CreateOpenXmlElement<DXMath.Run>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.BidirectionalOverride? GetBidirectionalOverride(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BidirectionalOverride>();
    if (element != null)
      return DMXW.BidirectionalOverrideConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBidirectionalOverride(DXW.Paragraph openXmlElement, DMW.BidirectionalOverride? value, DiffList? diffs, string? objName)
  {
    return DMXW.BidirectionalOverrideConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BidirectionalOverride>(), value, diffs, objName);
  }
  
  private static void SetBidirectionalOverride(DXW.Paragraph openXmlElement, DMW.BidirectionalOverride? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BidirectionalOverride>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BidirectionalOverrideConverter.CreateOpenXmlElement<DXW.BidirectionalOverride>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.BidirectionalEmbedding? GetBidirectionalEmbedding(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BidirectionalEmbedding>();
    if (element != null)
      return DMXW.BidirectionalEmbeddingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBidirectionalEmbedding(DXW.Paragraph openXmlElement, DMW.BidirectionalEmbedding? value, DiffList? diffs, string? objName)
  {
    return DMXW.BidirectionalEmbeddingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BidirectionalEmbedding>(), value, diffs, objName);
  }
  
  private static void SetBidirectionalEmbedding(DXW.Paragraph openXmlElement, DMW.BidirectionalEmbedding? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BidirectionalEmbedding>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BidirectionalEmbeddingConverter.CreateOpenXmlElement<DXW.BidirectionalEmbedding>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.RelationshipType? GetSubDocumentReference(DXW.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SubDocumentReference>();
    if (element != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubDocumentReference(DXW.Paragraph openXmlElement, DMW.RelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SubDocumentReference>(), value, diffs, objName);
  }
  
  private static void SetSubDocumentReference(DXW.Paragraph openXmlElement, DMW.RelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SubDocumentReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RelationshipTypeConverter.CreateOpenXmlElement<DXW.SubDocumentReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
*/

  public static DMW.ParagraphElement? CreateParagraphElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.Run run)
      return DMXW.RunConverter.CreateModelElement(run);
    if (openXmlElement is DXW.Hyperlink hyperlink)
      return DMXW.HyperlinkConverter.CreateModelElement(hyperlink);

      //value.Hyperlink = GetHyperlink(openXmlElement);

      //value.NoSpellError = GetNoSpellError(openXmlElement);
      //value.CustomXmlRun = GetCustomXmlRun(openXmlElement);
      //value.SimpleFields = GetSimpleFields(openXmlElement);
      //value.SdtRun = GetSdtRun(openXmlElement);

      //value.ChildParagraph = GetChildParagraph(openXmlElement);
      //value.OfficeMath = GetOfficeMath(openXmlElement);
      //value.Accent = GetAccent(openXmlElement);
      //value.Bar = GetBar(openXmlElement);
      //value.Box = GetBox(openXmlElement);
      //value.BorderBox = GetBorderBox(openXmlElement);
      //value.Delimiter = GetDelimiter(openXmlElement);
      //value.EquationArray = GetEquationArray(openXmlElement);
      //value.Fraction = GetFraction(openXmlElement);
      //value.MathFunction = GetMathFunction(openXmlElement);
      //value.GroupChar = GetGroupChar(openXmlElement);
      //value.LimitLower = GetLimitLower(openXmlElement);
      //value.LimitUpper = GetLimitUpper(openXmlElement);
      //value.Matrix = GetMatrix(openXmlElement);
      //value.Nary = GetNary(openXmlElement);
      //value.Phantom = GetPhantom(openXmlElement);
      //value.Radical = GetRadical(openXmlElement);
      //value.PreSubSuper = GetPreSubSuper(openXmlElement);
      //value.Subscript = GetSubscript(openXmlElement);
      //value.SubSuperscript = GetSubSuperscript(openXmlElement);
      //value.Superscript = GetSuperscript(openXmlElement);
      //value.BidirectionalOverride = GetBidirectionalOverride(openXmlElement);
      //value.BidirectionalEmbedding = GetBidirectionalEmbedding(openXmlElement);
      //value.SubDocumentReference = GetSubDocumentReference(openXmlElement);


    if (openXmlElement is DXW.ProofError proofError)
      return DMXW.ProofErrorConverter.CreateModelElement(proofError);
    if (openXmlElement is DXW.PermStart permStart)
      return DMXW.PermStartConverter.CreateModelElement(permStart);
    if (openXmlElement is DXW.PermEnd permEnd)
      return DMXW.PermEndConverter.CreateModelElement(permEnd);
    if (openXmlElement is DXW.BookmarkStart bookmarkStart)
      return DMXW.BookmarkStartConverter.CreateModelElement(bookmarkStart);
    if (openXmlElement is DXW.BookmarkEnd bookmarkEnd)
      return DMXW.BookmarkEndConverter.CreateModelElement(bookmarkEnd);
    if (openXmlElement is DXW.CommentRangeStart commentRangeStart)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(commentRangeStart);
    if (openXmlElement is DXW.CommentRangeEnd commentRangeEnd)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(commentRangeEnd);
    if (openXmlElement is DXW.MoveFromRangeStart moveFromRangeStart)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(moveFromRangeStart);
    if (openXmlElement is DXW.MoveFromRangeEnd moveFromRangeEnd)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(moveFromRangeEnd);
    if (openXmlElement is DXW.MoveToRangeStart moveToRangeStart)
      return DMXW.MoveBookmarkTypeConverter.CreateModelElement(moveToRangeStart);
    if (openXmlElement is DXW.MoveToRangeEnd moveToRangeEnd)
      return DMXW.MarkupRangeTypeConverter.CreateModelElement(moveToRangeEnd);
    if (openXmlElement is DXW.CustomXmlInsRangeStart customXmlInsRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(customXmlInsRangeStart);
    if (openXmlElement is DXW.CustomXmlInsRangeEnd customXmlInsRangeEnd)
      return DMXW.MarkupTypeConverter.CreateModelElement(customXmlInsRangeEnd);
    if (openXmlElement is DXW.CustomXmlDelRangeStart customXmlDelRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(customXmlDelRangeStart);
    if (openXmlElement is DXW.CustomXmlDelRangeEnd customXmlDelRangeEnd)
      return DMXW.MarkupTypeConverter.CreateModelElement(customXmlDelRangeEnd);
    if (openXmlElement is DXW.CustomXmlMoveFromRangeStart customXmlMoveFromRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(customXmlMoveFromRangeStart);
    if (openXmlElement is DXW.CustomXmlMoveFromRangeEnd customXmlMoveFromRangeEnd)
      return DMXW.MarkupTypeConverter.CreateModelElement(customXmlMoveFromRangeEnd);
    if (openXmlElement is DXW.CustomXmlMoveToRangeStart customXmlMoveToRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(customXmlMoveToRangeStart);
    if (openXmlElement is DXW.CustomXmlMoveToRangeEnd customXmlMoveToRangeEnd)
      return DMXW.MarkupTypeConverter.CreateModelElement(customXmlMoveToRangeEnd);
    if (openXmlElement is DXO2010W.CustomXmlConflictInsertionRangeStart customXmlConflictInsertionRangeStart)
      return DMXW.TrackChangeType2Converter.CreateModelElement(customXmlConflictInsertionRangeStart);
    if (openXmlElement is DXO2010W.CustomXmlConflictInsertionRangeEnd customXmlConflictInsertionRangeEnd)
      return DMXW.MarkupType2Converter.CreateModelElement(customXmlConflictInsertionRangeEnd);
    if (openXmlElement is DXO2010W.CustomXmlConflictDeletionRangeStart customXmlConflictDeletionRangeStart)
      return DMXW.TrackChangeType2Converter.CreateModelElement(customXmlConflictDeletionRangeStart);
    if (openXmlElement is DXO2010W.CustomXmlConflictDeletionRangeEnd customXmlConflictDeletionRangeEnd)
      return DMXW.MarkupType2Converter.CreateModelElement(customXmlConflictDeletionRangeEnd);
    if (openXmlElement is DXW.InsertedRun insertedRun)
      return DMXW.InsertedRunConverter.CreateModelElement(insertedRun);
    if (openXmlElement is DXW.DeletedRun deletedRun)
      return DMXW.DeletedRunConverter.CreateModelElement(deletedRun);
    if (openXmlElement is DXW.MoveFromRun moveFromRun)
      return DMXW.MoveFromRunConverter.CreateModelElement(moveFromRun);
    if (openXmlElement is DXW.MoveToRun moveToRun)
      return DMXW.MoveToRunConverter.CreateModelElement(moveToRun);
    if (openXmlElement is DXO2010W.RunConflictInsertion runConflictInsertion)
      return DMXW.RunConflictInsertionConverter.CreateModelElement(runConflictInsertion);
    if (openXmlElement is DXO2010W.RunConflictDeletion runConflictDeletion)
      return DMXW.RunConflictDeletionConverter.CreateModelElement(runConflictDeletion);
    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in Body.CreateModelElement method");
    return null;
  }

  public static bool CompareParagraphElement(DX.OpenXmlElement? openXmlElement, DMW.ParagraphElement? value, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;

      if (openXmlElement is DXW.ProofError proofError)
        return DMXW.ProofErrorConverter.CompareModelElement(proofError, value as DMW.ProofError, diffs, objName);
      if (openXmlElement is DXW.PermStart permStart)
        return DMXW.PermStartConverter.CompareModelElement(permStart, value as DMW.PermStart, diffs, objName);
      if (openXmlElement is DXW.PermEnd permEnd)
        return DMXW.PermEndConverter.CompareModelElement(permEnd, value as DMW.PermEnd, diffs, objName);
      if (openXmlElement is DXW.BookmarkStart bookmarkStart)
        return DMXW.BookmarkStartConverter.CompareModelElement(bookmarkStart, value as DMW.BookmarkStart, diffs, objName);
      if (openXmlElement is DXW.BookmarkEnd bookmarkEnd)
        return DMXW.BookmarkEndConverter.CompareModelElement(bookmarkEnd, value as DMW.BookmarkEnd, diffs, objName);
      if (openXmlElement is DXW.CommentRangeStart commentRangeStart)
        return DMXW.MarkupRangeTypeConverter.CompareModelElement(commentRangeStart, value as DMW.MarkupRangeType, diffs, objName);
      if (openXmlElement is DXW.CommentRangeEnd commentRangeEnd)
        return DMXW.MarkupRangeTypeConverter.CompareModelElement(commentRangeEnd, value as DMW.MarkupRangeType, diffs, objName);
      if (openXmlElement is DXW.MoveFromRangeStart moveFromRangeStart)
        return DMXW.MoveBookmarkTypeConverter.CompareModelElement(moveFromRangeStart, value as DMW.MoveBookmarkType, diffs, objName);
      if (openXmlElement is DXW.MoveFromRangeEnd moveFromRangeEnd)
        return DMXW.MarkupRangeTypeConverter.CompareModelElement(moveFromRangeEnd, value as DMW.MarkupRangeType, diffs, objName);
      if (openXmlElement is DXW.MoveToRangeStart moveToRangeStart)
        return DMXW.MoveBookmarkTypeConverter.CompareModelElement(moveToRangeStart, value as DMW.MoveBookmarkType, diffs, objName);
      if (openXmlElement is DXW.MoveToRangeEnd moveToRangeEnd)
        return DMXW.MarkupRangeTypeConverter.CompareModelElement(moveToRangeEnd, value as DMW.MarkupRangeType, diffs, objName);
      if (openXmlElement is DXW.CustomXmlInsRangeStart customXmlInsRangeStart)
        return DMXW.TrackChangeTypeConverter.CompareModelElement(customXmlInsRangeStart, value as DMW.TrackChangeType, diffs, objName);
      if (openXmlElement is DXW.CustomXmlInsRangeEnd customXmlInsRangeEnd)
        return DMXW.MarkupTypeConverter.CompareModelElement(customXmlInsRangeEnd, value as DMW.MarkupType, diffs, objName);
      if (openXmlElement is DXW.CustomXmlDelRangeStart customXmlDelRangeStart)
        return DMXW.TrackChangeTypeConverter.CompareModelElement(customXmlDelRangeStart, value as DMW.TrackChangeType, diffs, objName);
      if (openXmlElement is DXW.CustomXmlDelRangeEnd customXmlDelRangeEnd)
        return DMXW.MarkupTypeConverter.CompareModelElement(customXmlDelRangeEnd, value as DMW.MarkupType, diffs, objName);
      if (openXmlElement is DXW.CustomXmlMoveFromRangeStart customXmlMoveFromRangeStart)
        return DMXW.TrackChangeTypeConverter.CompareModelElement(customXmlMoveFromRangeStart, value as DMW.TrackChangeType, diffs, objName);
      if (openXmlElement is DXW.CustomXmlMoveFromRangeEnd customXmlMoveFromRangeEnd)
        return DMXW.MarkupTypeConverter.CompareModelElement(customXmlMoveFromRangeEnd, value as DMW.MarkupType, diffs, objName);
      if (openXmlElement is DXW.CustomXmlMoveToRangeStart customXmlMoveToRangeStart)
        return DMXW.TrackChangeTypeConverter.CompareModelElement(customXmlMoveToRangeStart, value as DMW.TrackChangeType, diffs, objName);
      if (openXmlElement is DXW.CustomXmlMoveToRangeEnd customXmlMoveToRangeEnd)
        return DMXW.MarkupTypeConverter.CompareModelElement(customXmlMoveToRangeEnd, value as DMW.MarkupType, diffs, objName);
      if (openXmlElement is DXO2010W.CustomXmlConflictInsertionRangeStart customXmlConflictInsertionRangeStart)
        return DMXW.TrackChangeType2Converter.CompareModelElement(customXmlConflictInsertionRangeStart, value as DMW.TrackChangeType2, diffs, objName);
      if (openXmlElement is DXO2010W.CustomXmlConflictInsertionRangeEnd customXmlConflictInsertionRangeEnd)
        return DMXW.MarkupType2Converter.CompareModelElement(customXmlConflictInsertionRangeEnd, value as DMW.MarkupType2, diffs, objName);
      if (openXmlElement is DXO2010W.CustomXmlConflictDeletionRangeStart customXmlConflictDeletionRangeStart)
        return DMXW.TrackChangeType2Converter.CompareModelElement(customXmlConflictDeletionRangeStart, value as DMW.TrackChangeType2, diffs, objName);
      if (openXmlElement is DXO2010W.CustomXmlConflictDeletionRangeEnd customXmlConflictDeletionRangeEnd)
        return DMXW.MarkupType2Converter.CompareModelElement(customXmlConflictDeletionRangeEnd, value as DMW.MarkupType2, diffs, objName);
      if (openXmlElement is DXW.InsertedRun insertedRun)
        return DMXW.InsertedRunConverter.CompareModelElement(insertedRun, value as DMW.InsertedRun, diffs, objName);
      if (openXmlElement is DXW.DeletedRun deletedRun)
        return DMXW.DeletedRunConverter.CompareModelElement(deletedRun, value as DMW.DeletedRun, diffs, objName);
      if (openXmlElement is DXW.MoveFromRun moveFromRun)
        return DMXW.MoveFromRunConverter.CompareModelElement(moveFromRun, value as DMW.MoveFromRun, diffs, objName);
      if (openXmlElement is DXW.MoveToRun moveToRun)
        return DMXW.MoveToRunConverter.CompareModelElement(moveToRun, value as DMW.MoveToRun, diffs, objName);
      if (openXmlElement is DXO2010W.RunConflictInsertion runConflictInsertion)
        return DMXW.RunConflictInsertionConverter.CompareModelElement(runConflictInsertion, value as DMW.RunConflictInsertion, diffs, objName);
      if (openXmlElement is DXO2010W.RunConflictDeletion runConflictDeletion)
        return DMXW.RunConflictDeletionConverter.CompareModelElement(runConflictDeletion, value as DMW.RunConflictDeletion, diffs, objName);
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElement CreateOpenXmlElement(DMW.ParagraphElement value)
  {
    if (value is DMW.ProofError proofError)
      return DMXW.ProofErrorConverter.CreateOpenXmlElement(proofError);
    if (value is DMW.PermStart permStart)
      return DMXW.PermStartConverter.CreateOpenXmlElement(permStart);
    if (value is DMW.PermEnd permEnd)
      return DMXW.PermEndConverter.CreateOpenXmlElement(permEnd);
    if (value is DMW.BookmarkStart bookmarkStart)
      return DMXW.BookmarkStartConverter.CreateOpenXmlElement(bookmarkStart);
    if (value is DMW.BookmarkEnd bookmarkEnd)
      return DMXW.BookmarkEndConverter.CreateOpenXmlElement(bookmarkEnd);
    if (value is DMW.CommentRangeStart commentRangeStart)
      return DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement(commentRangeStart);
    if (value is DMW.CommentRangeEnd commentRangeEnd)
      return DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement(commentRangeEnd);
    if (value is DMW.MoveFromRangeStart moveFromRangeStart)
      return DMXW.MoveBookmarkTypeConverter.CreateOpenXmlElement(moveFromRangeStart);
    if (value is DMW.MoveFromRangeEnd moveFromRangeEnd)
      return DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement(moveFromRangeEnd);
    if (value is DMW.MoveToRangeStart moveToRangeStart)
      return DMXW.MoveBookmarkTypeConverter.CreateOpenXmlElement(moveToRangeStart);
    if (value is DMW.MoveToRangeEnd moveToRangeEnd)
      return DMXW.MarkupRangeTypeConverter.CreateOpenXmlElement<DXW.MoveFromRangeEnd>(moveToRangeEnd);
    if (value is DMW.CustomXmlInsRangeStart customXmlInsRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlInsRangeStart>(customXmlInsRangeStart);
    if (value is DMW.CustomXmlInsRangeEnd customXmlInsRangeEnd)
      return DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlInsRangeEnd>(customXmlInsRangeEnd);
    if (value is DMW.CustomXmlDelRangeStart customXmlDelRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlDelRangeStart>(customXmlDelRangeStart);
    if (value is DMW.CustomXmlDelRangeEnd customXmlDelRangeEnd)
      return DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlDelRangeEnd>(customXmlDelRangeEnd);
    if (value is DMW.CustomXmlMoveFromRangeStart customXmlMoveFromRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveFromRangeStart>(customXmlMoveFromRangeStart);
    if (value is DMW.CustomXmlMoveFromRangeEnd customXmlMoveFromRangeEnd)
      return DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveFromRangeEnd>(customXmlMoveFromRangeEnd);
    if (value is DMW.CustomXmlMoveToRangeStart customXmlMoveToRangeStart)
      return DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveToRangeStart>(customXmlMoveToRangeStart);
    if (value is DMW.CustomXmlMoveToRangeEnd customXmlMoveToRangeEnd)
      return DMXW.MarkupTypeConverter.CreateOpenXmlElement<DXW.CustomXmlMoveToRangeEnd>(customXmlMoveToRangeEnd);
    if (value is DMW.CustomXmlConflictInsertionRangeStart customXmlConflictInsertionRangeStart)
      return DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictInsertionRangeStart>(customXmlConflictInsertionRangeStart);
    if (value is DMW.CustomXmlConflictInsertionRangeEnd customXmlConflictInsertionRangeEnd)
      return DMXW.MarkupType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictInsertionRangeEnd>(customXmlConflictInsertionRangeEnd);
    if (value is DMW.CustomXmlConflictDeletionRangeStart customXmlConflictDeletionRangeStart)
      return DMXW.TrackChangeType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictDeletionRangeStart>(customXmlConflictDeletionRangeStart);
    if (value is DMW.CustomXmlConflictDeletionRangeEnd customXmlConflictDeletionRangeEnd)
      return DMXW.MarkupType2Converter.CreateOpenXmlElement<DXO2010W.CustomXmlConflictDeletionRangeEnd>(customXmlConflictDeletionRangeEnd);
    if (value is DMW.InsertedRun insertedRun)
      return DMXW.InsertedRunConverter.CreateOpenXmlElement<DXW.InsertedRun>(insertedRun);
    if (value is DMW.DeletedRun deletedRun)
      return DMXW.DeletedRunConverter.CreateOpenXmlElement<DXW.DeletedRun>(deletedRun);
    if (value is DMW.MoveFromRun moveFromRun)
      return DMXW.MoveFromRunConverter.CreateOpenXmlElement<DXW.MoveFromRun>(moveFromRun);
    if (value is DMW.MoveToRun moveToRun)
      return DMXW.MoveToRunConverter.CreateOpenXmlElement<DXW.MoveToRun>(moveToRun);
    if (value is DMW.RunConflictInsertion runConflictInsertion)
      return DMXW.RunConflictInsertionConverter.CreateOpenXmlElement<DXO2010W.RunConflictInsertion>(runConflictInsertion);
    if (value is DMW.RunConflictDeletion runConflictDeletion)
      return DMXW.RunConflictDeletionConverter.CreateOpenXmlElement<DXO2010W.RunConflictDeletion>(runConflictDeletion);
    throw new InvalidOperationException($"Value of type \"{value.GetType()}\" not supported in ParagraphConverter.CreateOpenXmlElement method");
  }

  public static DMW.Paragraph? CreateModelElement(DXW.Paragraph? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Paragraph();
      value.RsidParagraphMarkRevision = GetRsidParagraphMarkRevision(openXmlElement);
      value.RsidParagraphAddition = GetRsidParagraphAddition(openXmlElement);
      value.RsidParagraphDeletion = GetRsidParagraphDeletion(openXmlElement);
      value.RsidParagraphProperties = GetRsidParagraphProperties(openXmlElement);
      value.RsidRunAdditionDefault = GetRsidRunAdditionDefault(openXmlElement);
      value.ParagraphId = GetParagraphId(openXmlElement);
      value.TextId = GetTextId(openXmlElement);
      value.ParagraphProperties = GetParagraphProperties(openXmlElement);
      var elements = openXmlElement.Elements().ToArray();
      foreach (var element in elements)
      {
        var item = CreateParagraphElement(element);
        if (item != null)
          value.Add(item);
      }
      //value.Run = GetRun(openXmlElement);
      //value.Hyperlink = GetHyperlink(openXmlElement);

      //value.NoSpellError = GetNoSpellError(openXmlElement);
      //value.CustomXmlRun = GetCustomXmlRun(openXmlElement);
      //value.SimpleFields = GetSimpleFields(openXmlElement);
      //value.SdtRun = GetSdtRun(openXmlElement);

      //value.ChildParagraph = GetChildParagraph(openXmlElement);
      //value.OfficeMath = GetOfficeMath(openXmlElement);
      //value.Accent = GetAccent(openXmlElement);
      //value.Bar = GetBar(openXmlElement);
      //value.Box = GetBox(openXmlElement);
      //value.BorderBox = GetBorderBox(openXmlElement);
      //value.Delimiter = GetDelimiter(openXmlElement);
      //value.EquationArray = GetEquationArray(openXmlElement);
      //value.Fraction = GetFraction(openXmlElement);
      //value.MathFunction = GetMathFunction(openXmlElement);
      //value.GroupChar = GetGroupChar(openXmlElement);
      //value.LimitLower = GetLimitLower(openXmlElement);
      //value.LimitUpper = GetLimitUpper(openXmlElement);
      //value.Matrix = GetMatrix(openXmlElement);
      //value.Nary = GetNary(openXmlElement);
      //value.Phantom = GetPhantom(openXmlElement);
      //value.Radical = GetRadical(openXmlElement);
      //value.PreSubSuper = GetPreSubSuper(openXmlElement);
      //value.Subscript = GetSubscript(openXmlElement);
      //value.SubSuperscript = GetSubSuperscript(openXmlElement);
      //value.Superscript = GetSuperscript(openXmlElement);
      //value.BidirectionalOverride = GetBidirectionalOverride(openXmlElement);
      //value.BidirectionalEmbedding = GetBidirectionalEmbedding(openXmlElement);
      //value.SubDocumentReference = GetSubDocumentReference(openXmlElement);
      return value;
    }
    return null;
  }

  public static bool CompareParagraphElement(DXW.Paragraph? openXmlElement, DMW.Paragraph? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRsidParagraphMarkRevision(openXmlElement, value.RsidParagraphMarkRevision, diffs, objName))
        ok = false;
      if (!CmpRsidParagraphAddition(openXmlElement, value.RsidParagraphAddition, diffs, objName))
        ok = false;
      if (!CmpRsidParagraphDeletion(openXmlElement, value.RsidParagraphDeletion, diffs, objName))
        ok = false;
      if (!CmpRsidParagraphProperties(openXmlElement, value.RsidParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpRsidRunAdditionDefault(openXmlElement, value.RsidRunAdditionDefault, diffs, objName))
        ok = false;
      if (!CmpParagraphId(openXmlElement, value.ParagraphId, diffs, objName))
        ok = false;
      if (!CmpTextId(openXmlElement, value.TextId, diffs, objName))
        ok = false;
      if (!CmpParagraphProperties(openXmlElement, value.ParagraphProperties, diffs, objName))
        ok = false;
      var paraItems = value.ToArray();
      var elements = openXmlElement.Elements().ToArray();
      for (int i = 0; i < System.Math.Min(paraItems.Count(), elements.Count()); i++)
      {
        var element = elements[i];
        var item = paraItems[i];
        if (!CompareParagraphElement(element, item, diffs, objName))
          ok = false;
      }
      if (!Int32ValueConverter.CmpValue(elements.Count(), paraItems.Count(), diffs, objName, "ParagraphItems.Count"))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static DXW.Paragraph CreateOpenXmlElement(DMW.Paragraph value)
  {
    var openXmlElement = new DXW.Paragraph();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.Paragraph openXmlElement, DMW.Paragraph value)
  {
    SetRsidParagraphMarkRevision(openXmlElement, value.RsidParagraphMarkRevision);
    SetRsidParagraphAddition(openXmlElement, value.RsidParagraphAddition);
    SetRsidParagraphDeletion(openXmlElement, value.RsidParagraphDeletion);
    SetRsidParagraphProperties(openXmlElement, value.RsidParagraphProperties);
    SetRsidRunAdditionDefault(openXmlElement, value.RsidRunAdditionDefault);
    SetParagraphId(openXmlElement, value.ParagraphId);
    SetTextId(openXmlElement, value.TextId);
    SetParagraphProperties(openXmlElement, value.ParagraphProperties);
    var paraItems = value.ToArray();
    var elements = openXmlElement.Elements();
    var elementsEnumerator = elements.GetEnumerator();
    for (int i = 0; i < paraItems.Count(); i++)
    {
      var item = paraItems[i];
      OpenXmlElement? element = elementsEnumerator.MoveNext() ? elementsEnumerator.Current : null;
      if (element == null)
      {
        element = CreateOpenXmlElement(item);
        openXmlElement.AddChild(element);
      }
    }

  }
}
