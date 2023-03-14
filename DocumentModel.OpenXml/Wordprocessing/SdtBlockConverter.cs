using DocumentFormat.OpenXml;

using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtBlock Class.
/// </summary>
public static class SdtBlockConverter
{

  #region SdtContentBlock elements conversion
  public static DMW.ISdtBlockElement? CreateSdtContentBlockModelElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.Paragraph paragraph)
      return DMXW.ParagraphConverter.CreateModelElement(paragraph);
    if (openXmlElement is DXW.Table table)
      return DMXW.TableConverter.CreateModelElement(table);
    if (openXmlElement is DXW.SdtBlock sdtBlock)
      return DMXW.SdtBlockConverter.CreateModelElement(sdtBlock);
    if (openXmlElement is DXW.CustomXmlBlock customXmlBlock)
      return DMXW.CustomXmlBlockConverter.CreateModelElement(customXmlBlock);

    var result = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (result != null)
      return result;
    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in SdtBlockConverter.CreateModelElement method");
    return null;
  }

  public static bool CompareSdtContentBlockElement(DX.OpenXmlElement? openXmlElement, DM.IModelElement? value, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && value != null)
    {
      if (openXmlElement is DXW.Paragraph paragraph && value is DMW.Paragraph paragraphModel)
        return DMXW.ParagraphConverter.CompareModelElement(paragraph, paragraphModel, diffs, objName);
      if (openXmlElement is DXW.Table table && value is DMW.Table tableModel)
        return DMXW.TableConverter.CompareModelElement(table, tableModel, diffs, objName);
      if (openXmlElement is DXW.SdtBlock sdtBlock && value is DMW.SdtBlock sdtBlockModel)
        return DMXW.SdtBlockConverter.CompareModelElement(sdtBlock, sdtBlockModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlBlock customXmlBlock && value is DMW.CustomXmlBlock customXmlBlockModel)
        return DMXW.CustomXmlBlockConverter.CompareModelElement(customXmlBlock, customXmlBlockModel, diffs, objName);

      if (value is DMW.ICommonElement commonElementModel)
      {
        var result = CommonMarkersConverter.CompareModelElement(openXmlElement, commonElementModel, diffs, objName);
        if (result != null)
          return (bool)result;
      }
      diffs?.Add(objName, "@Type", openXmlElement.GetType().Name, value.GetType().Name);
      return false;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElement CreateSdtContentBlockOpenXmlElement(IModelElement value)
  {
    if (value is DMW.Paragraph paragraph)
      return DMXW.ParagraphConverter.CreateOpenXmlElement(paragraph);
    if (value is DMW.Table table)
      return DMXW.TableConverter.CreateOpenXmlElement(table);
    if (value is DMW.SdtBlock sdtBlock)
      return DMXW.SdtBlockConverter.CreateOpenXmlElement(sdtBlock);
    if (value is DMW.CustomXmlBlock customXmlBlock)
      return DMXW.CustomXmlBlockConverter.CreateOpenXmlElement(customXmlBlock);

    var result = CommonMarkersConverter.CreateOpenXmlElement(value as DMW.ICommonElement);
    if (result != null) return result;
    throw new InvalidOperationException($"Value of type \"{value.GetType()}\" not supported in SdtBlockConverter.CreateOpenXmlElement method");
  }

  public static bool UpdateSdtContentBlockOpenXmlElement(DX.OpenXmlElement openXmlElement, IModelElement value)
  {
    if (openXmlElement is DXW.Paragraph paragraph && value is DMW.Paragraph paragraphModel)
      return DMXW.ParagraphConverter.UpdateOpenXmlElement(paragraph, paragraphModel);
    if (openXmlElement is DXW.Table table && value is DMW.Table tableModel)
      return DMXW.TableConverter.UpdateOpenXmlElement(table, tableModel);
    if (openXmlElement is DXW.SdtBlock sdtBlock && value is DMW.SdtBlock sdtBlockModel)
      return DMXW.SdtBlockConverter.UpdateOpenXmlElement(sdtBlock, sdtBlockModel);
    if (openXmlElement is DXW.CustomXmlBlock customXmlBlock && value is DMW.CustomXmlBlock customXmlBlockModel)
      return DMXW.CustomXmlBlockConverter.UpdateOpenXmlElement(customXmlBlock, customXmlBlockModel);
    return false;
  }

  #endregion

  #region StdBlock conversion
  public static DMW.SdtBlock? CreateModelElement(DXW.SdtBlock? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.SdtBlock();
      model.SdtProperties = SdtElementConverter.GetSdtProperties(openXmlElement);
      model.SdtEndCharProperties = SdtElementConverter.GetSdtEndCharProperties(openXmlElement);
      ElementCollectionConverter<DMW.ISdtBlockElement>.FillModelElementCollection(openXmlElement.SdtContentBlock, model, 
        (CreateModelElementMethod)CreateSdtContentBlockModelElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.SdtBlock? openXmlElement, DMW.SdtBlock? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!SdtElementConverter.CmpSdtProperties(openXmlElement, model.SdtProperties, diffs, objName))
        ok = false;
      if (!SdtElementConverter.CmpSdtEndCharProperties(openXmlElement, model.SdtEndCharProperties, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DMW.ISdtBlockElement>.CompareOpenXmlElementCollection(openXmlElement.SdtContentBlock, model,
        (CompareOpenXmlElementMethod)CompareSdtContentBlockElement, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXW.SdtBlock CreateOpenXmlElement(DMW.SdtBlock model)
  {
    var openXmlElement = new DXW.SdtBlock();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.SdtBlock openXmlElement, DMW.SdtBlock model)
  {
    SdtElementConverter.SetSdtProperties(openXmlElement, model.SdtProperties);
    SdtElementConverter.SetSdtEndCharProperties(openXmlElement, model.SdtEndCharProperties);
    return ElementCollectionConverter<DMW.ISdtBlockElement>.UpdateOpenXmlElementCollection(openXmlElement, model,
      (CompareOpenXmlElementMethod)CompareSdtContentBlockElement,
      (UpdateOpenXmlElementMethod)UpdateSdtContentBlockOpenXmlElement,
      (CreateOpenXmlElementMethod)CreateSdtContentBlockOpenXmlElement);
  }

  #endregion
}
