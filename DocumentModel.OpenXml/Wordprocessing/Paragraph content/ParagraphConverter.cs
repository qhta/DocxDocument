namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Paragraph class from/to OpenXml converter.
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

  private static bool CmpRsidParagraphMarkRevision(DXW.Paragraph openXmlElement, DM.HexInt? model, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidParagraphMarkRevision?.Value, model, diffs, objName, "RsidParagraphMarkRevision");
  }

  private static void SetRsidParagraphMarkRevision(DXW.Paragraph openXmlElement, DM.HexInt? model)
  {
    if (model != null)
      openXmlElement.RsidParagraphMarkRevision = model.ToString();
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

  private static bool CmpRsidParagraphAddition(DXW.Paragraph openXmlElement, DM.HexInt? model, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidParagraphAddition?.Value, model, diffs, objName, "RsidParagraphAddition");
  }

  private static void SetRsidParagraphAddition(DXW.Paragraph openXmlElement, DM.HexInt? model)
  {
    if (model != null)
      openXmlElement.RsidParagraphAddition = model.ToString();
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

  private static bool CmpRsidParagraphDeletion(DXW.Paragraph openXmlElement, DM.HexInt? model, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidParagraphDeletion?.Value, model, diffs, objName, "RsidParagraphDeletion");
  }

  private static void SetRsidParagraphDeletion(DXW.Paragraph openXmlElement, DM.HexInt? model)
  {
    if (model != null)
      openXmlElement.RsidParagraphDeletion = model.ToString();
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

  private static bool CmpRsidParagraphProperties(DXW.Paragraph openXmlElement, DM.HexInt? model, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidParagraphProperties?.Value, model, diffs, objName, "RsidParagraphProperties");
  }

  private static void SetRsidParagraphProperties(DXW.Paragraph openXmlElement, DM.HexInt? model)
  {
    if (model != null)
      openXmlElement.RsidParagraphProperties = model.ToString();
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

  private static bool CmpRsidRunAdditionDefault(DXW.Paragraph openXmlElement, DM.HexInt? model, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidRunAdditionDefault?.Value, model, diffs, objName, "RsidRunAdditionDefault");
  }

  private static void SetRsidRunAdditionDefault(DXW.Paragraph openXmlElement, DM.HexInt? model)
  {
    if (model != null)
      openXmlElement.RsidRunAdditionDefault = model.ToString();
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

  private static bool CmpParagraphId(DXW.Paragraph openXmlElement, DM.HexInt? model, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.ParagraphId?.Value, model, diffs, objName, "ParagraphId");
  }

  private static void SetParagraphId(DXW.Paragraph openXmlElement, DM.HexInt? model)
  {
    if (model != null)
      openXmlElement.ParagraphId = model.ToString();
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

  private static bool CmpTextId(DXW.Paragraph openXmlElement, DM.HexInt? model, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.TextId?.Value, model, diffs, objName, "TextId");
  }

  private static void SetTextId(DXW.Paragraph openXmlElement, DM.HexInt? model)
  {
    if (model != null)
      openXmlElement.TextId = model.ToString();
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

  private static bool CmpParagraphProperties(DXW.Paragraph openXmlElement, DMW.ParagraphProperties? model, DiffList? diffs, string? objName)
  {
    return DMXW.ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ParagraphProperties>(), model, diffs, objName?.Concat2(".", openXmlElement?.GetType().Name));
  }

  private static void SetParagraphProperties(DXW.Paragraph openXmlElement, DMW.ParagraphProperties? model)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (model != null)
    {
      itemElement = DMXW.ParagraphPropertiesConverter.CreateOpenXmlElement(model);
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

  private static bool CmpNoSpellError(DXW.Paragraph openXmlElement, Boolean? model, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.NoSpellError, model, diffs, objName, "NoSpellError");
  }

  private static void SetNoSpellError(DXW.Paragraph openXmlElement, Boolean? model)
  {
    openXmlElement.NoSpellError = BooleanValueConverter.CreateOnOffValue(model);
  }
  #endregion

  #region Paragraph conversion
  public static DMW.Paragraph? CreateModelElement(DXW.Paragraph? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Paragraph();
      model.RsidParagraphMarkRevision = GetRsidParagraphMarkRevision(openXmlElement);
      model.RsidParagraphAddition = GetRsidParagraphAddition(openXmlElement);
      model.RsidParagraphDeletion = GetRsidParagraphDeletion(openXmlElement);
      model.RsidParagraphProperties = GetRsidParagraphProperties(openXmlElement);
      model.RsidRunAdditionDefault = GetRsidRunAdditionDefault(openXmlElement);
      model.ParagraphId = GetParagraphId(openXmlElement);
      model.TextId = GetTextId(openXmlElement);
      model.NoSpellError = GetNoSpellError(openXmlElement);
      model.ParagraphProperties = GetParagraphProperties(openXmlElement);
      ElementCollectionConverter<DMW.IParagraphContent>.FillModelElementCollection(
        openXmlElement.Where(item=>item is not DXW.ParagraphProperties), model,
        ParagraphContentConverter.CreateParagraphContent);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Paragraph? openXmlElement, DMW.Paragraph? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpRsidParagraphMarkRevision(openXmlElement, model.RsidParagraphMarkRevision, diffs, objName))
        ok = false;
      if (!CmpRsidParagraphAddition(openXmlElement, model.RsidParagraphAddition, diffs, objName))
        ok = false;
      if (!CmpRsidParagraphDeletion(openXmlElement, model.RsidParagraphDeletion, diffs, objName))
        ok = false;
      if (!CmpRsidParagraphProperties(openXmlElement, model.RsidParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpRsidRunAdditionDefault(openXmlElement, model.RsidRunAdditionDefault, diffs, objName))
        ok = false;
      if (!CmpParagraphId(openXmlElement, model.ParagraphId, diffs, objName))
        ok = false;
      if (!CmpTextId(openXmlElement, model.TextId, diffs, objName))
        ok = false;
      if (!CmpNoSpellError(openXmlElement, model.NoSpellError, diffs, objName))
        ok = false;
      if (!CmpParagraphProperties(openXmlElement, model.ParagraphProperties, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DMW.IParagraphContent>.CompareOpenXmlElementCollection(
        openXmlElement.Where(item=>item is not DXW.ParagraphProperties), model,
        ParagraphContentConverter.CompareParagraphContent, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXW.Paragraph CreateOpenXmlElement(DMW.Paragraph model)
  {
    var openXmlElement = new DXW.Paragraph();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.Paragraph openXmlElement, DMW.Paragraph model)
  {
    SetRsidParagraphMarkRevision(openXmlElement, model.RsidParagraphMarkRevision);
    SetRsidParagraphAddition(openXmlElement, model.RsidParagraphAddition);
    SetRsidParagraphDeletion(openXmlElement, model.RsidParagraphDeletion);
    SetRsidParagraphProperties(openXmlElement, model.RsidParagraphProperties);
    SetRsidRunAdditionDefault(openXmlElement, model.RsidRunAdditionDefault);
    SetParagraphId(openXmlElement, model.ParagraphId);
    SetTextId(openXmlElement, model.TextId);
    SetNoSpellError(openXmlElement, model.NoSpellError);
    SetParagraphProperties(openXmlElement, model.ParagraphProperties);
    return ElementCollectionConverter<DMW.IParagraphContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      ParagraphContentConverter.CompareParagraphContent,
      ParagraphContentConverter.UpdateOpenXmlParagraphContent,
      ParagraphContentConverter.CreateOpenXmlParagraphContent);
  }
  #endregion
}
