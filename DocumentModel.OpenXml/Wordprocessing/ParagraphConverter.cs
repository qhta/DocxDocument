using System.Xml.Linq;

using DocumentFormat.OpenXml;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Paragraph class converter.
/// </summary>
public static class ParagraphConverter
{
  #region Revision Identifier for Paragraph Glyph Formatting
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
  #endregion

  #region Revision Identifier for Paragraph
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
  #endregion

  #region Revision Identifier for Paragraph Deletion
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
  #endregion

  #region Revision Identifier for Paragraph Properties
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
  #endregion

  #region Default Revision Identifier for Runs
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
  #endregion

  #region Paragraph Id, this property is only available in Office 2010 and later.
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
  #endregion

  #region Text Id, this property is only available in Office 2010 and later.
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
  #endregion

  #region Paragraph Properties
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
  #endregion

  #region NoSpellErr, this property is only available in Office 2010 and later.
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
  #endregion

  #region Paragraph elements conversion
  public static DMW.ParagraphElement? CreateParagraphElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.ParagraphProperties)
      return null;
    if (openXmlElement is DXW.Run run)
      return DMXW.RunConverter.CreateModelElement(run);
    if (openXmlElement is DXW.Hyperlink hyperlink)
      return DMXW.HyperlinkConverter.CreateModelElement(hyperlink);
    if (openXmlElement is DXW.CustomXmlRun customXmlRun)
      return DMXW.CustomXmlRunConverter.CreateModelElement(customXmlRun);
    if (openXmlElement is DXW.SimpleField simpleField)
      return DMXW.SimpleFieldConverter.CreateModelElement(simpleField);
    if (openXmlElement is DXW.SdtRun sdtRun)
      return DMXW.SdtRunConverter.CreateModelElement(sdtRun);
    if (openXmlElement is DXW.BidirectionalOverride bidirectionalOverride)
      return DMXW.BidirectionalOverrideConverter.CreateModelElement(bidirectionalOverride);
    if (openXmlElement is DXW.BidirectionalEmbedding bidirectionalEmbedding)
      return DMXW.BidirectionalEmbeddingConverter.CreateModelElement(bidirectionalEmbedding);
    if (openXmlElement is DXW.SubDocumentReference subDocumentReference)
      return DMXW.RelationshipTypeConverter.CreateModelElement(subDocumentReference);

    if (openXmlElement is DXMath.Paragraph paragraph)
      return DMXMath.ParagraphConverter.CreateModelElement(paragraph);
    if (openXmlElement is DXMath.OfficeMath officeMath)
      return DMXMath.OfficeMathConverter.CreateModelElement(officeMath);
    if (openXmlElement is DXMath.Accent accent)
      return DMXMath.AccentConverter.CreateModelElement(accent);
    if (openXmlElement is DXMath.Bar bar)
      return DMXMath.BarConverter.CreateModelElement(bar);
    if (openXmlElement is DXMath.Box box)
      return DMXMath.BoxConverter.CreateModelElement(box);
    if (openXmlElement is DXMath.BorderBox borderBox)
      return DMXMath.BorderBoxConverter.CreateModelElement(borderBox);
    if (openXmlElement is DXMath.Delimiter delimiter)
      return DMXMath.DelimiterConverter.CreateModelElement(delimiter);
    if (openXmlElement is DXMath.EquationArray equationArray)
      return DMXMath.EquationArrayConverter.CreateModelElement(equationArray);
    if (openXmlElement is DXMath.Fraction fraction)
      return DMXMath.FractionConverter.CreateModelElement(fraction);
    if (openXmlElement is DXMath.MathFunction mathFunction)
      return DMXMath.MathFunctionConverter.CreateModelElement(mathFunction);
    if (openXmlElement is DXMath.GroupChar groupChar)
      return DMXMath.GroupCharConverter.CreateModelElement(groupChar);
    if (openXmlElement is DXMath.LimitLower limitLower)
      return DMXMath.LimitLowerConverter.CreateModelElement(limitLower);
    if (openXmlElement is DXMath.LimitUpper limitUpper)
      return DMXMath.LimitUpperConverter.CreateModelElement(limitUpper);
    if (openXmlElement is DXMath.Matrix matrix)
      return DMXMath.MatrixConverter.CreateModelElement(matrix);
    if (openXmlElement is DXMath.Nary nary)
      return DMXMath.NaryConverter.CreateModelElement(nary);
    if (openXmlElement is DXMath.Phantom phantom)
      return DMXMath.PhantomConverter.CreateModelElement(phantom);
    if (openXmlElement is DXMath.Radical radical)
      return DMXMath.RadicalConverter.CreateModelElement(radical);
    if (openXmlElement is DXMath.PreSubSuper preSubSuper)
      return DMXMath.PreSubSuperConverter.CreateModelElement(preSubSuper);
    if (openXmlElement is DXMath.Subscript subscript)
      return DMXMath.SubscriptConverter.CreateModelElement(subscript);
    if (openXmlElement is DXMath.SubSuperscript subSuperscript)
      return DMXMath.SubSuperscriptConverter.CreateModelElement(subSuperscript);
    if (openXmlElement is DXMath.Superscript superscript)
      return DMXMath.SuperscriptConverter.CreateModelElement(superscript);

    var result = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (result != null)
      return result;
    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in ParagraphConverter.CreateModelElement method");
    return null;
  }

  public static bool CompareParagraphElement(DX.OpenXmlElement? openXmlElement, DMW.ParagraphElement? value, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && value != null)
    {
      if (openXmlElement is DXW.Run run)
        return DMXW.RunConverter.CompareModelElement(run, value as DMW.Run, diffs, objName);
      if (openXmlElement is DXW.Hyperlink hyperlink)
        return DMXW.HyperlinkConverter.CompareModelElement(hyperlink, value as DMW.Hyperlink, diffs, objName);
      if (openXmlElement is DXW.CustomXmlRun customXmlRun)
        return DMXW.CustomXmlRunConverter.CompareModelElement(customXmlRun, value as DMW.CustomXmlRun, diffs, objName);
      if (openXmlElement is DXW.SimpleField simpleField)
        return DMXW.SimpleFieldConverter.CompareModelElement(simpleField, value as DMW.SimpleField, diffs, objName);
      if (openXmlElement is DXW.SdtRun sdtRun)
        return DMXW.SdtRunConverter.CompareModelElement(sdtRun, value as DMW.SdtRun, diffs, objName);
      if (openXmlElement is DXW.BidirectionalOverride bidirectionalOverride)
        return DMXW.BidirectionalOverrideConverter.CompareModelElement(bidirectionalOverride, value as DMW.BidirectionalOverride, diffs, objName);
      if (openXmlElement is DXW.BidirectionalEmbedding bidirectionalEmbedding)
        return DMXW.BidirectionalEmbeddingConverter.CompareModelElement(bidirectionalEmbedding, value as DMW.BidirectionalEmbedding, diffs, objName);
      if (openXmlElement is DXW.SubDocumentReference subDocumentReference)
        return DMXW.RelationshipTypeConverter.CompareModelElement(subDocumentReference, value as DMW.RelationshipType, diffs, objName);

      if (openXmlElement is DXMath.Paragraph paragraph)
        return DMXMath.ParagraphConverter.CompareModelElement(paragraph, value as DMMath.Paragraph, diffs, objName);
      if (openXmlElement is DXMath.OfficeMath officeMath)
        return DMXMath.OfficeMathConverter.CompareModelElement(officeMath, value as DMMath.OfficeMath, diffs, objName);
      if (openXmlElement is DXMath.Accent accent)
        return DMXMath.AccentConverter.CompareModelElement(accent, value as DMMath.Accent, diffs, objName);
      if (openXmlElement is DXMath.Bar bar)
        return DMXMath.BarConverter.CompareModelElement(bar, value as DMMath.Bar, diffs, objName);
      if (openXmlElement is DXMath.Box box)
        return DMXMath.BoxConverter.CompareModelElement(box, value as DMMath.Box, diffs, objName);
      if (openXmlElement is DXMath.BorderBox borderBox)
        return DMXMath.BorderBoxConverter.CompareModelElement(borderBox, value as DMMath.BorderBox, diffs, objName);
      if (openXmlElement is DXMath.Delimiter delimiter)
        return DMXMath.DelimiterConverter.CompareModelElement(delimiter, value as DMMath.Delimiter, diffs, objName);
      if (openXmlElement is DXMath.EquationArray equationArray)
        return DMXMath.EquationArrayConverter.CompareModelElement(equationArray, value as DMMath.EquationArray, diffs, objName);
      if (openXmlElement is DXMath.Fraction fraction)
        return DMXMath.FractionConverter.CompareModelElement(fraction, value as DMMath.Fraction, diffs, objName);
      if (openXmlElement is DXMath.MathFunction mathFunction)
        return DMXMath.MathFunctionConverter.CompareModelElement(mathFunction, value as DMMath.MathFunction, diffs, objName);
      if (openXmlElement is DXMath.GroupChar groupChar)
        return DMXMath.GroupCharConverter.CompareModelElement(groupChar, value as DMMath.GroupChar, diffs, objName);
      if (openXmlElement is DXMath.LimitLower limitLower)
        return DMXMath.LimitLowerConverter.CompareModelElement(limitLower, value as DMMath.LimitLower, diffs, objName);
      if (openXmlElement is DXMath.LimitUpper limitUpper)
        return DMXMath.LimitUpperConverter.CompareModelElement(limitUpper, value as DMMath.LimitUpper, diffs, objName);
      if (openXmlElement is DXMath.Matrix matrix)
        return DMXMath.MatrixConverter.CompareModelElement(matrix, value as DMMath.Matrix, diffs, objName);
      if (openXmlElement is DXMath.Nary nary)
        return DMXMath.NaryConverter.CompareModelElement(nary, value as DMMath.Nary, diffs, objName);
      if (openXmlElement is DXMath.Phantom phantom)
        return DMXMath.PhantomConverter.CompareModelElement(phantom, value as DMMath.Phantom, diffs, objName);
      if (openXmlElement is DXMath.Radical radical)
        return DMXMath.RadicalConverter.CompareModelElement(radical, value as DMMath.Radical, diffs, objName);
      if (openXmlElement is DXMath.PreSubSuper preSubSuper)
        return DMXMath.PreSubSuperConverter.CompareModelElement(preSubSuper, value as DMMath.PreSubSuper, diffs, objName);
      if (openXmlElement is DXMath.Subscript subscript)
        return DMXMath.SubscriptConverter.CompareModelElement(subscript, value as DMMath.Subscript, diffs, objName);
      if (openXmlElement is DXMath.SubSuperscript subSuperscript)
        return DMXMath.SubSuperscriptConverter.CompareModelElement(subSuperscript, value as DMMath.SubSuperscript, diffs, objName);
      if (openXmlElement is DXMath.Superscript superscript)
        return DMXMath.SuperscriptConverter.CompareModelElement(superscript, value as DMMath.Superscript, diffs, objName);

      return CommonMarkersConverter.CompareModelElement(openXmlElement, value as DMW.CommonElement, diffs, objName);
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElement CreateOpenXmlElement(DMW.ParagraphElement value)
  {
    if (value is DMW.Run run)
      return DMXW.RunConverter.CreateOpenXmlElement(run);
    if (value is DMW.Hyperlink hyperlink)
      return DMXW.HyperlinkConverter.CreateOpenXmlElement(hyperlink);
    if (value is DMW.CustomXmlRun customXmlRun)
      return DMXW.CustomXmlRunConverter.CreateOpenXmlElement(customXmlRun);
    if (value is DMW.SimpleField simpleField)
      return DMXW.SimpleFieldConverter.CreateOpenXmlElement(simpleField);
    if (value is DMW.SdtRun sdtRun)
      return DMXW.SdtRunConverter.CreateOpenXmlElement(sdtRun);
    if (value is DMW.BidirectionalOverride bidirectionalOverride)
      return DMXW.BidirectionalOverrideConverter.CreateOpenXmlElement(bidirectionalOverride);
    if (value is DMW.BidirectionalEmbedding bidirectionalEmbedding)
      return DMXW.BidirectionalEmbeddingConverter.CreateOpenXmlElement(bidirectionalEmbedding);
    if (value is DMW.SubDocumentReference subDocumentReference)
      return DMXW.RelationshipTypeConverter.CreateOpenXmlElement(subDocumentReference);

    if (value is DMMath.Paragraph paragraph)
      return DMXMath.ParagraphConverter.CreateOpenXmlElement(paragraph);
    if (value is DMMath.OfficeMath officeMath)
      return DMXMath.OfficeMathConverter.CreateOpenXmlElement(officeMath);
    if (value is DMMath.Accent accent)
      return DMXMath.AccentConverter.CreateOpenXmlElement(accent);
    if (value is DMMath.Bar bar)
      return DMXMath.BarConverter.CreateOpenXmlElement(bar);
    if (value is DMMath.Box box)
      return DMXMath.BoxConverter.CreateOpenXmlElement(box);
    if (value is DMMath.BorderBox borderBox)
      return DMXMath.BorderBoxConverter.CreateOpenXmlElement(borderBox);
    if (value is DMMath.Delimiter delimiter)
      return DMXMath.DelimiterConverter.CreateOpenXmlElement(delimiter);
    if (value is DMMath.EquationArray equationArray)
      return DMXMath.EquationArrayConverter.CreateOpenXmlElement(equationArray);
    if (value is DMMath.Fraction fraction)
      return DMXMath.FractionConverter.CreateOpenXmlElement(fraction);
    if (value is DMMath.MathFunction mathFunction)
      return DMXMath.MathFunctionConverter.CreateOpenXmlElement(mathFunction);
    if (value is DMMath.GroupChar groupChar)
      return DMXMath.GroupCharConverter.CreateOpenXmlElement(groupChar);
    if (value is DMMath.LimitLower limitLower)
      return DMXMath.LimitLowerConverter.CreateOpenXmlElement(limitLower);
    if (value is DMMath.LimitUpper limitUpper)
      return DMXMath.LimitUpperConverter.CreateOpenXmlElement(limitUpper);
    if (value is DMMath.Matrix matrix)
      return DMXMath.MatrixConverter.CreateOpenXmlElement(matrix);
    if (value is DMMath.Nary nary)
      return DMXMath.NaryConverter.CreateOpenXmlElement(nary);
    if (value is DMMath.Phantom phantom)
      return DMXMath.PhantomConverter.CreateOpenXmlElement(phantom);
    if (value is DMMath.Radical radical)
      return DMXMath.RadicalConverter.CreateOpenXmlElement(radical);
    if (value is DMMath.PreSubSuper preSubSuper)
      return DMXMath.PreSubSuperConverter.CreateOpenXmlElement(preSubSuper);
    if (value is DMMath.Subscript subscript)
      return DMXMath.SubscriptConverter.CreateOpenXmlElement(subscript);
    if (value is DMMath.SubSuperscript subSuperscript)
      return DMXMath.SubSuperscriptConverter.CreateOpenXmlElement(subSuperscript);
    if (value is DMMath.Superscript superscript)
      return DMXMath.SuperscriptConverter.CreateOpenXmlElement(superscript);

    var result = CommonMarkersConverter.CreateOpenXmlElement(value as DMW.CommonElement);
    if (result != null) return result;
    throw new InvalidOperationException($"Value of type \"{value.GetType()}\" not supported in ParagraphConverter.CreateOpenXmlElement method");
  }
  #endregion

  #region Paragraph conversion
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
      value.NoSpellError = GetNoSpellError(openXmlElement);
      value.ParagraphProperties = GetParagraphProperties(openXmlElement);
      var elements = openXmlElement.Elements().ToArray();
      foreach (var element in elements)
      {
        var item = CreateParagraphElement(element);
        if (item != null)
          value.Add(item);
      }
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
      if (!CmpNoSpellError(openXmlElement, value.NoSpellError, diffs, objName))
        ok = false;
      if (!CmpParagraphProperties(openXmlElement, value.ParagraphProperties, diffs, objName))
        ok = false;
      var paraItems = value.ToArray();
      var elements = openXmlElement.Elements().Where(item => !(item is DXW.ParagraphProperties)).ToArray();
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
    SetNoSpellError(openXmlElement, value.NoSpellError);
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
  #endregion

}
