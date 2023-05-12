namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Comment"/> class from/to OpenXml converter.
/// </summary>
public static class CommentConverter
{
  #region Initials conversion.
  private static String? GetInitials(DXW.Comment openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Initials);
  }

  private static bool CmpInitials(DXW.Comment openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Initials, value, diffs, objName, "Initials");
  }

  private static void SetInitials(DXW.Comment openXmlElement, String? value)
  {
    openXmlElement.Initials = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Author conversion.
  private static String? GetAuthor(DXW.Comment openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }

  private static bool CmpAuthor(DXW.Comment openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }

  private static void SetAuthor(DXW.Comment openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Date conversion.
  private static DateTime? GetDate(DXW.Comment openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }

  private static bool CmpDate(DXW.Comment openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }

  private static void SetDate(DXW.Comment openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  #endregion

  #region Annotation Identifier conversion.
  private static String? GetId(DXW.Comment openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }

  private static bool CmpId(DXW.Comment openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }

  private static void SetId(DXW.Comment openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Comment content conversion
  public static DMW.ICommentContent? CreateCommentContent(DX.OpenXmlElement? openXmlElement, object? data = null)
  {
    if (openXmlElement is DXW.Paragraph paragraph)
      return DMXW.ParagraphConverter.CreateModelElement(paragraph);
    if (openXmlElement is DXW.Table table)
      return DMXW.TableConverter.CreateModelElement(table);
    if (openXmlElement is DXW.AltChunk altChunk)
      return DMXW.AltChunkConverter.CreateModelElement(altChunk);
    if (openXmlElement is DXW.CustomXmlBlock customXmlBlock)
      return DMXW.CustomXmlBlockConverter.CreateModelElement(customXmlBlock);
    if (openXmlElement is DXW.SdtBlock stdBlock)
      return DMXW.SdtBlockConverter.CreateModelElement(stdBlock);

    var commonMarker = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (commonMarker != null)
      return commonMarker;

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in CommentConverter.CreateModelElement method");
    return null;
  }

  public static bool CompareCommentContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, 
    DiffList? diffs = null, string? objName = null, object? data = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.Paragraph paragraph && model is DMW.Paragraph paragraphModel)
        return DMXW.ParagraphConverter.CompareModelElement(paragraph, paragraphModel, diffs, objName);
      if (openXmlElement is DXW.Table table && model is DMW.Table tableModel)
        return DMXW.TableConverter.CompareModelElement(table, tableModel, diffs, objName);
      if (openXmlElement is DXW.AltChunk altChunk && model is DMW.AltChunk altChunkModel)
        return DMXW.AltChunkConverter.CompareModelElement(altChunk, altChunkModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlBlock customXmlBlock && model is DMW.CustomXmlBlock customXmlBlockModel)
        return DMXW.CustomXmlBlockConverter.CompareModelElement(customXmlBlock, customXmlBlockModel, diffs, objName);
      if (openXmlElement is DXW.SdtBlock stdBlock && model is DMW.SdtBlock stdBlockModel)
        return DMXW.SdtBlockConverter.CompareModelElement(stdBlock, stdBlockModel, diffs, objName);

      if (model is DMW.ICommonContent commonElementModel)
      {
        var result = CommonMarkersConverter.CompareModelElement(openXmlElement, commonElementModel, diffs, objName);
        if (result != null)
          return (bool)result;
      }
      diffs?.Add(objName, "Type", openXmlElement.GetType().Name, model.GetType().Name);
      return false;

    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElement CreateOpenXmlCommentContent(DM.IModelElement model, object? data = null)
  {
    if (model is DMW.Paragraph paragraph)
      return DMXW.ParagraphConverter.CreateOpenXmlElement(paragraph);
    if (model is DMW.Table table)
      return DMXW.TableConverter.CreateOpenXmlElement(table);
    if (model is DMW.AltChunk altChunk)
      return DMXW.AltChunkConverter.CreateOpenXmlElement(altChunk);
    if (model is DMW.CustomXmlBlock customXmlBlock)
      return DMXW.CustomXmlBlockConverter.CreateOpenXmlElement(customXmlBlock);
    if (model is DMW.SdtBlock stdBlock)
      return DMXW.SdtBlockConverter.CreateOpenXmlElement(stdBlock);

    var commonMarker = CommonMarkersConverter.CreateOpenXmlElement(model as DMW.ICommonContent);
    if (commonMarker != null) return commonMarker;
    throw new InvalidOperationException($"Type of type \"{model.GetType()}\" not supported in CommentConverter.CreateOpenXmlCommentElement method");
  }

  public static bool UpdateOpenXmlCommentContent(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, object? data = null)
  {
    if (openXmlElement != null && model != null)
    {

      if (model is DMW.ICommonContent commonElementModel)
      {
        var result = CommonMarkersConverter.UpdateOpenXmlElement(openXmlElement, commonElementModel);
        if (result != null)
          return (bool)result;
      }
      return true;
    }
    return false;
  }
  #endregion

  #region Comment model conversion
  public static DMW.Comment? CreateModelElement(DXW.Comment? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Comment();
      model.Initials = GetInitials(openXmlElement);
      model.Author = GetAuthor(openXmlElement);
      model.Date = GetDate(openXmlElement);
      model.Id = GetId(openXmlElement);
      ElementCollectionConverter<DMW.ICommentContent>.FillModelElementCollection(openXmlElement, model,
        CreateCommentContent);

      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Comment? openXmlElement, DMW.Comment? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpInitials(openXmlElement, model.Initials, diffs, objName))
        ok = false;
      if (!CmpAuthor(openXmlElement, model.Author, diffs, objName))
        ok = false;
      if (!CmpDate(openXmlElement, model.Date, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, model.Id, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DMW.ICommentContent>.CompareOpenXmlElementCollection(
        openXmlElement.Where(item => item is not DXW.ParagraphProperties), model,
        CompareCommentContent, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Comment model)
    where OpenXmlElementType : DXW.Comment, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.Comment openXmlElement, DMW.Comment model)
  {
    SetInitials(openXmlElement, model.Initials);
    SetAuthor(openXmlElement, model.Author);
    SetDate(openXmlElement, model.Date);
    SetId(openXmlElement, model.Id);
    ElementCollectionConverter<DMW.ICommentContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      CompareCommentContent,
      UpdateOpenXmlCommentContent,
      CreateOpenXmlCommentContent);
  }
  #endregion
}
