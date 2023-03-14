using System.Xml.Linq;

using DocumentFormat.OpenXml;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Paragraph class converter.
/// </summary>
public static class ParagraphConverter
{
  #region Revision Identifier for Paragraph Glyph Formatting formatting
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

  #region Revision Identifier for Paragraph conversion
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

  #region Revision Identifier for Paragraph Deletion conversion
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

  #region Revision Identifier for Paragraph Properties conversion
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

  #region Default Revision Identifier for Runs conversion
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

  #region ParagraphId conversion
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

  #region TextId conversion
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

  #region ParagraphProperties conversion
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

  #region NoSpellErr conversion
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
  public static DMW.IParagraphElement? CreateParagraphElement(DX.OpenXmlElement? openXmlElement)
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

    var commonMarker = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (commonMarker != null)
      return commonMarker;

    var commonMathElement = CommonMathConverter.CreateModelElement(openXmlElement);
    if (commonMathElement != null)
      return commonMathElement;

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in ParagraphConverter.CreateModelElement method");
    return null;
  }

  public static bool CompareParagraphElement(DX.OpenXmlElement? openXmlElement, DMW.IParagraphElement? value, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && value != null)
    {
      if (openXmlElement is DXW.Run run && value is DMW.Run runModel)
        return DMXW.RunConverter.CompareModelElement(run, runModel, diffs, objName);
      if (openXmlElement is DXW.Hyperlink hyperlink && value is DMW.Hyperlink hyperlinkModel)
        return DMXW.HyperlinkConverter.CompareModelElement(hyperlink, hyperlinkModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlRun customXmlRun && value is DMW.CustomXmlRun customXmlRunModel)
        return DMXW.CustomXmlRunConverter.CompareModelElement(customXmlRun, customXmlRunModel, diffs, objName);
      if (openXmlElement is DXW.SimpleField simpleField && value is DMW.SimpleField simpleFieldModel)
        return DMXW.SimpleFieldConverter.CompareModelElement(simpleField, simpleFieldModel, diffs, objName);
      if (openXmlElement is DXW.SdtRun sdtRun && value is DMW.SdtRun sdtRunModel)
        return DMXW.SdtRunConverter.CompareModelElement(sdtRun, sdtRunModel, diffs, objName);
      if (openXmlElement is DXW.BidirectionalOverride bidirectionalOverride && value is DMW.BidirectionalOverride bidirectionalOverrideModel)
        return DMXW.BidirectionalOverrideConverter.CompareModelElement(bidirectionalOverride, bidirectionalOverrideModel, diffs, objName);
      if (openXmlElement is DXW.BidirectionalEmbedding bidirectionalEmbedding && value is DMW.BidirectionalEmbedding bidirectionalEmbeddingModel)
        return DMXW.BidirectionalEmbeddingConverter.CompareModelElement(bidirectionalEmbedding, bidirectionalEmbeddingModel, diffs, objName);
      if (openXmlElement is DXW.SubDocumentReference subDocumentReference && value is DMW.SubDocumentReference subDocumentReferenceModel)
        return DMXW.RelationshipTypeConverter.CompareModelElement(subDocumentReference, subDocumentReferenceModel, diffs, objName);

      if (value is DMW.ICommonElement commonElementModel)
      {
        var result = CommonMarkersConverter.CompareModelElement(openXmlElement, commonElementModel, diffs, objName);
        if (result != null)
          return (bool)result;
      }
      if (value is DMMath.ICommonMathElement commonMathModel)
      {
        var result = CommonMathConverter.CompareModelElement(openXmlElement, commonMathModel, diffs, objName);
        if (result != null)
          return (bool)result;
      }
      diffs?.Add(objName, "Type", openXmlElement.GetType().Name, value.GetType().Name);
      return false;

    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElement CreateOpenXmlElement(DMW.IParagraphElement value)
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

    var commonMarker = CommonMarkersConverter.CreateOpenXmlElement(value as DMW.ICommonElement);
    if (commonMarker != null) return commonMarker;

    var commonMathElement = CommonMathConverter.CreateOpenXmlElement(value as DMMath.ICommonMathElement);
    if (commonMathElement != null) return commonMathElement;

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
        if (item is DXW.ParagraphProperties)
          continue;
        if (item != null)
          value.Add(item);
      }
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Paragraph? openXmlElement, DMW.Paragraph? value, DiffList? diffs, string? objName)
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
      if (!Int32ValueConverter.CmpValue(elements.Count(), paraItems.Count(), diffs, objName, "Paragraph.Items.Count"))
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

  public static bool UpdateOpenXmlElement(DXW.Paragraph openXmlElement, DMW.Paragraph value)
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
    return true;
  }
  #endregion

}
