using DocumentFormat.OpenXml;

using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtBlock Class.
/// </summary>
public static class SdtBlockConverter
{

  #region SdtContentBlock elements conversion

  /// <summary>
  /// Creates an item model element for a SdtContentBlock element item
  /// </summary>
  /// <param name="openXmlElement">Item element of SdtContentBlock element</param>
  /// <returns>Newly created model element (or <c>null</c> if openXml element is <c>null</c>).</returns>
  /// <exception cref="InvalidOperationException">Thrown if openXml element type is not recognized.</exception>
  public static DMW.ISdtBlockContent? CreateSdtContentBlockModelElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.Paragraph paragraph)
      return DMXW.ParagraphConverter.CreateModelElement(paragraph);
    if (openXmlElement is DXW.Table table)
      return DMXW.TableConverter.CreateModelElement(table);
    if (openXmlElement is DXW.SdtBlock sdtBlock)
      return DMXW.SdtBlockConverter.CreateModelElement(sdtBlock);
    if (openXmlElement is DXW.CustomXmlBlock customXmlBlock)
      return DMXW.CustomXmlBlockConverter.CreateModelElement(customXmlBlock);

    var model = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (model != null)
      return model;
    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in SdtBlockConverter.CreateModelElement method");
    return null;
  }

  /// <summary>
  /// Compares a SdtContentBlock element item with a model element that was created from that openXml element
  /// </summary>
  /// <param name="openXmlElement">Item element of SdtContentBlock element</param>
  /// <param name="model">A model element collection created from that openXmlElement.</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the model element is equivalent to the openXmlElement, <c>false</c> otherwise</returns>
  public static bool CompareSdtContentBlockElement(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.Paragraph paragraph && model is DMW.Paragraph paragraphModel)
        return DMXW.ParagraphConverter.CompareModelElement(paragraph, paragraphModel, diffs, objName);
      if (openXmlElement is DXW.Table table && model is DMW.Table tableModel)
        return DMXW.TableConverter.CompareModelElement(table, tableModel, diffs, objName);
      if (openXmlElement is DXW.SdtBlock sdtBlock && model is DMW.SdtBlock sdtBlockModel)
        return DMXW.SdtBlockConverter.CompareModelElement(sdtBlock, sdtBlockModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlBlock customXmlBlock && model is DMW.CustomXmlBlock customXmlBlockModel)
        return DMXW.CustomXmlBlockConverter.CompareModelElement(customXmlBlock, customXmlBlockModel, diffs, objName);

      if (model is DMW.ICommonContent commonElementModel)
      {
        var result = CommonMarkersConverter.CompareModelElement(openXmlElement, commonElementModel, diffs, objName);
        if (result != null)
          return (bool)result;
      }
      diffs?.Add(objName, "@Type", openXmlElement.GetType().Name, model.GetType().Name);
      return false;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  /// <summary>
  /// Creates a SdtContentBlock element item based on a model element.
  /// </summary>
  /// <param name="model">A model element with valid content.</param>
  /// <returns>Newly created openXml element</returns>
  /// <exception cref="InvalidOperationException">Thrown if a model element type is not recognized.</exception>
  public static OpenXmlElement CreateSdtContentBlockOpenXmlElement(IModelElement model)
  {
    if (model is DMW.Paragraph paragraph)
      return DMXW.ParagraphConverter.CreateOpenXmlElement(paragraph);
    if (model is DMW.Table table)
      return DMXW.TableConverter.CreateOpenXmlElement(table);
    if (model is DMW.SdtBlock sdtBlock)
      return DMXW.SdtBlockConverter.CreateOpenXmlElement(sdtBlock);
    if (model is DMW.CustomXmlBlock customXmlBlock)
      return DMXW.CustomXmlBlockConverter.CreateOpenXmlElement(customXmlBlock);

    var result = CommonMarkersConverter.CreateOpenXmlElement(model as DMW.ICommonContent);
    if (result != null) return result;
    throw new InvalidOperationException($"Model of type \"{model.GetType()}\" not supported in SdtBlockConverter.CreateOpenXmlParagraphElement method");
  }

  /// <summary>
  /// Updates a SdtContentBlock element item based on a model element.
  /// </summary>
  /// <param name="openXmlElement">An openXml element to update.</param>
  /// <param name="model">A model element with valid content.</param>
  /// <returns><c>True</c> if the openXml element was updated succesfully, <c>false</c> otherwise</returns>
  public static bool UpdateSdtContentBlockOpenXmlElement(DX.OpenXmlElement openXmlElement, IModelElement model)
  {
    if (openXmlElement is DXW.Paragraph paragraph && model is DMW.Paragraph paragraphModel)
      return DMXW.ParagraphConverter.UpdateOpenXmlElement(paragraph, paragraphModel);
    if (openXmlElement is DXW.Table table && model is DMW.Table tableModel)
      return DMXW.TableConverter.UpdateOpenXmlElement(table, tableModel);
    if (openXmlElement is DXW.SdtBlock sdtBlock && model is DMW.SdtBlock sdtBlockModel)
      return DMXW.SdtBlockConverter.UpdateOpenXmlElement(sdtBlock, sdtBlockModel);
    if (openXmlElement is DXW.CustomXmlBlock customXmlBlock && model is DMW.CustomXmlBlock customXmlBlockModel)
      return DMXW.CustomXmlBlockConverter.UpdateOpenXmlElement(customXmlBlock, customXmlBlockModel);
    return false;
  }

  #endregion

  #region StdBlock conversion

  /// <summary>
  /// Creates a model element for a SdtBlock element.
  /// </summary>
  /// <param name="openXmlElement">SdtBlock element read from DocumentFormat.OpenXml document</param>
  /// <returns>Newly created model element (or <c>null</c> if openXml element is <c>null</c>).</returns>
  public static DMW.SdtBlock? CreateModelElement(DXW.SdtBlock? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.SdtBlock();
      model.SdtProperties = SdtElementConverter.GetSdtProperties(openXmlElement);
      model.SdtEndCharProperties = SdtElementConverter.GetSdtEndCharProperties(openXmlElement);
      ElementCollectionConverter<DMW.ISdtBlockContent>.FillModelElementCollection(openXmlElement.SdtContentBlock, model, 
        (CreateModelElementMethod)CreateSdtContentBlockModelElement);
      return model;
    }
    return null;
  }

  /// <summary>
  /// Compares a SdtRow openXml element and a SdtRow model element that was created from that openXml element.
  /// </summary>
  /// <param name="openXmlElement">An openXml element read from DocumentFormat.OpenXml document.</param>
  /// <param name="model">A model element created from the openXml element.</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the model element is equivalent to openXml element, <c>false</c> otherwise</returns>
  public static bool CompareModelElement(DXW.SdtBlock? openXmlElement, DMW.SdtBlock? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!SdtElementConverter.CmpSdtProperties(openXmlElement, model.SdtProperties, diffs, objName))
        ok = false;
      if (!SdtElementConverter.CmpSdtEndCharProperties(openXmlElement, model.SdtEndCharProperties, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DMW.ISdtBlockContent>.CompareOpenXmlElementCollection(openXmlElement.SdtContentBlock, model,
        (CompareOpenXmlElementMethod)CompareSdtContentBlockElement, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  /// <summary>
  /// Creates a SdtBlock openXml element based on a SdtBlock model element.
  /// </summary>
  /// <param name="model">A model element with valid content.</param>
  /// <returns>Newly created openXml element</returns>
  public static DXW.SdtBlock CreateOpenXmlElement(DMW.SdtBlock model)
  {
    var openXmlElement = new DXW.SdtBlock();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  /// <summary>
  /// Updates a SdtBlock element based on a SdtBlock model element.
  /// </summary>
  /// <param name="openXmlElement">An openXml element to update.</param>
  /// <param name="model">A model element with valid content.</param>
  /// <returns><c>True</c> if the openXml element was updated succesfully, <c>false</c> otherwise</returns>
  public static bool UpdateOpenXmlElement(DXW.SdtBlock openXmlElement, DMW.SdtBlock model)
  {
    SdtElementConverter.SetSdtProperties(openXmlElement, model.SdtProperties);
    SdtElementConverter.SetSdtEndCharProperties(openXmlElement, model.SdtEndCharProperties);
    return ElementCollectionConverter<DMW.ISdtBlockContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      (CompareOpenXmlElementMethod)CompareSdtContentBlockElement,
      (UpdateOpenXmlElementMethod)UpdateSdtContentBlockOpenXmlElement,
      (CreateOpenXmlElementMethod)CreateSdtContentBlockOpenXmlElement);
  }

  #endregion
}
