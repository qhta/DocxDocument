namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.BidirectionalOverride"/> class from/to OpenXml converter.
/// </summary>
public static class BidirectionalOverrideConverter
{
  #region Type conversion.
  private static DMW.DirectionKind? GetVal(DXW.BidirectionalOverride openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.DirectionValues, DMW.DirectionKind>(openXmlElement?.Val?.Value);
  }
  
  private static bool CmpVal(DXW.BidirectionalOverride openXmlElement, DMW.DirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.DirectionValues, DMW.DirectionKind>(openXmlElement?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetVal(DXW.BidirectionalOverride openXmlElement, DMW.DirectionKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DXW.DirectionValues, DMW.DirectionKind>(value);
  }
  #endregion

  #region BidirectionalOverride elements conversion
  public static DMW.IBidirectionalContent? CreateBidirectionalOverrideContent(DX.OpenXmlElement? openXmlElement)
  {
    return ParagraphContentConverter.CreateParagraphContent(openXmlElement) as DMW.IBidirectionalContent;
  }

  public static bool CompareBidirectionalOverrideContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, DiffList? diffs = null, string? objName = null)
  {
    return ParagraphContentConverter.CompareParagraphContent(openXmlElement, model, diffs, objName);
  }

  public static OpenXmlElement CreateOpenXmlBidirectionalOverrideContent(DM.IModelElement model)
  {
    return ParagraphContentConverter.CreateOpenXmlParagraphContent(model);
  }

  public static bool UpdateOpenXmlBidirectionalOverrideContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model)
  {
    return ParagraphContentConverter.UpdateOpenXmlParagraphContent(openXmlElement, model);
  }
  #endregion

  #region BidirectionalOverride model conversion.
  public static DMW.BidirectionalOverride? CreateModelElement(DXW.BidirectionalOverride? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.BidirectionalOverride();
      model.Type = GetVal(openXmlElement);
      ElementCollectionConverter<DMW.IBidirectionalContent>.FillModelElementCollection(openXmlElement, model,
        CreateBidirectionalOverrideContent);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.BidirectionalOverride? openXmlElement, DMW.BidirectionalOverride? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, model.Type, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DMW.IBidirectionalContent>.CompareOpenXmlElementCollection(
        openXmlElement, model,
        CompareBidirectionalOverrideContent, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXW.BidirectionalOverride CreateOpenXmlElement(DMW.BidirectionalOverride model)
  {
    var openXmlElement = new DXW.BidirectionalOverride();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.BidirectionalOverride openXmlElement, DMW.BidirectionalOverride model)
  {
    SetVal(openXmlElement, model.Type);
    return ElementCollectionConverter<DMW.IBidirectionalContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      CompareBidirectionalOverrideContent,
      UpdateOpenXmlBidirectionalOverrideContent,
      CreateOpenXmlBidirectionalOverrideContent);
  }
  #endregion
}
