namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.FootnoteEndnoteType"/> class from/to OpenXml converter.
/// </summary>
public static class FootnoteEndnoteTypeConverter
{
  #region Footnote/Endnote Type conversion.
  private static DMW.FootnoteEndnoteKind? GetType(DXW.FootnoteEndnoteType openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.FootnoteEndnoteValues, DMW.FootnoteEndnoteKind>(openXmlElement?.Type?.Value);
  }

  private static bool CmpType(DXW.FootnoteEndnoteType openXmlElement, DMW.FootnoteEndnoteKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.FootnoteEndnoteValues, DMW.FootnoteEndnoteKind>(openXmlElement?.Type?.Value, value, diffs, objName);
  }

  private static void SetType(DXW.FootnoteEndnoteType openXmlElement, DMW.FootnoteEndnoteKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DXW.FootnoteEndnoteValues, DMW.FootnoteEndnoteKind>(value);
  }
  #endregion

  #region Footnote/Endnote ID conversion.
  private static Int64? GetId(DXW.FootnoteEndnoteType openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  private static bool CmpId(DXW.FootnoteEndnoteType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "AnnotationId", openXmlElement?.Id?.Value, value);
    return false;
  }

  private static void SetId(DXW.FootnoteEndnoteType openXmlElement, Int64? value)
  {
    openXmlElement.Id = value;
  }
  #endregion

  #region FootnoteEndnoteType model conversion.
  public static ElementType? CreateModelElement<ElementType>(DXW.FootnoteEndnoteType? openXmlElement)
    where ElementType : DMW.FootnoteEndnoteType, new()
  {
    if (openXmlElement != null)
    {
      var model = new ElementType();
      model.Type = GetType(openXmlElement);
      model.Id = GetId(openXmlElement);
      ElementCollectionConverter<DMW.IStoryContent>.FillModelElementCollection(openXmlElement, model,
        BlockLevelElementsConverter.CreateBlockLevelElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.FootnoteEndnoteType? openXmlElement, DMW.FootnoteEndnoteType? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, model.Type, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, model.Id, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DMW.IStoryContent>.CompareOpenXmlElementCollection
         (openXmlElement, model,
         BlockLevelElementsConverter.CompareBlockLevelElement, diffs, objName))
        ok = false;

      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.FootnoteEndnoteType model)
    where OpenXmlElementType : DXW.FootnoteEndnoteType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.FootnoteEndnoteType openXmlElement, DMW.FootnoteEndnoteType model)
  {
    SetType(openXmlElement, model.Type);
    SetId(openXmlElement, model.Id);
    return ElementCollectionConverter<DMW.IStoryContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      BlockLevelElementsConverter.CompareBlockLevelElement,
      BlockLevelElementsConverter.UpdateOpenXmlElement,
      BlockLevelElementsConverter.CreateOpenXmlElement);
  }
  #endregion
}
