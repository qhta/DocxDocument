namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.BidirectionalEmbedding"/> class from/to OpenXml converter.
/// </summary>
public static class BidirectionalEmbeddingConverter
{
  #region Type conversion.
  private static DMW.DirectionKind? GetVal(DXW.BidirectionalEmbedding openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.DirectionValues, DMW.DirectionKind>(openXmlElement?.Val?.Value);
  }
  
  private static bool CmpVal(DXW.BidirectionalEmbedding openXmlElement, DMW.DirectionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.DirectionValues, DMW.DirectionKind>(openXmlElement?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetVal(DXW.BidirectionalEmbedding openXmlElement, DMW.DirectionKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DXW.DirectionValues, DMW.DirectionKind>(value);
  }
  #endregion

  #region BidirectionalEmbedding elements conversion
  public static DMW.IBidirectionalContent? CreateBidirectionalEmbeddingContent(DX.OpenXmlElement? openXmlElement)
  {
    return ParagraphContentConverter.CreateParagraphContent(openXmlElement) as DMW.IBidirectionalContent;
  }

  public static bool CompareBidirectionalEmbeddingContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, 
    DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return ParagraphContentConverter.CompareParagraphContent(openXmlElement, model, diffs, objName, propName);
  }

  public static OpenXmlElement CreateOpenXmlBidirectionalEmbeddingContent(DM.IModelElement model)
  {
    return ParagraphContentConverter.CreateOpenXmlParagraphContent(model);
  }

  public static bool UpdateOpenXmlBidirectionalEmbeddingContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model)
  {
    return ParagraphContentConverter.UpdateOpenXmlParagraphContent(openXmlElement, model);
  }
  #endregion

  #region BidirectionalEmbedding model conversion.
  public static DMW.BidirectionalEmbedding? CreateModelElement(DXW.BidirectionalEmbedding? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.BidirectionalEmbedding();
      model.Type = GetVal(openXmlElement);
      ElementCollectionConverter<DMW.IBidirectionalContent>.FillModelElementCollection(openXmlElement, model,
        CreateBidirectionalEmbeddingContent);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.BidirectionalEmbedding? openXmlElement, DMW.BidirectionalEmbedding? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, model.Type, diffs, objName, propName))
        ok = false;
      if (!ElementCollectionConverter<DMW.IBidirectionalContent>.CompareOpenXmlElementCollection(
        openXmlElement, model,
        CompareBidirectionalEmbeddingContent, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXW.BidirectionalEmbedding CreateOpenXmlElement(DMW.BidirectionalEmbedding model)
  {
    var openXmlElement = new DXW.BidirectionalEmbedding();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.BidirectionalEmbedding openXmlElement, DMW.BidirectionalEmbedding model)
  {
    SetVal(openXmlElement, model.Type);
    return ElementCollectionConverter<DMW.IBidirectionalContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      CompareBidirectionalEmbeddingContent,
      UpdateOpenXmlBidirectionalEmbeddingContent,
      CreateOpenXmlBidirectionalEmbeddingContent);
  }
  #endregion
}
