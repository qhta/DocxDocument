namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Cell-Level Structured Document Tag converter from/to OpenXml.
///</summary>
public static class SdtCellConverter
{
  #region SdtContentCell elements conversion

    /// <summary>
  /// Creates item model element for SdtContentCell element item
  /// </summary>
  /// <param name="openXmlElement">Item element of SdtContentCell element</param>
  /// <returns>Newly created model element (or <c>null</c> if openXml element is <c>null</c>).</returns>
  /// <exception cref="InvalidOperationException">Thrown if openXml element type is not recognized.</exception>
  public static DMW.ISdtCellElement? CreateSdtContentCellModelElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.TableCell tableCell)
      return DMXW.TableCellConverter.CreateModelElement(tableCell);
    if (openXmlElement is DXW.SdtCell sdtCell)
      return DMXW.SdtCellConverter.CreateModelElement(sdtCell);
    if (openXmlElement is DXW.CustomXmlCell customXmlCell)
      return DMXW.CustomXmlCellConverter.CreateModelElement(customXmlCell);

    var model = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (model != null)
      return model;
    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in SdtCellConverter.CreateModelElement method");
    return null;
  }

  /// <summary>
  /// Compares SdtContentCell element item with a model element that was created from that openXml element
  /// </summary>
  /// <param name="openXmlElement">Item element of SdtContentCell element</param>
  /// <param name="model">A model element collection created from that openXmlElement.</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the model element is equivalent to the openXmlElement, <c>false</c> otherwise</returns>
  public static bool CompareSdtContentCellElement(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.TableCell tableCell && model is DMW.TableCell tableCellModel)
        return DMXW.TableCellConverter.CompareModelElement(tableCell, tableCellModel, diffs, objName);
      if (openXmlElement is DXW.SdtCell sdtCell && model is DMW.SdtCell sdtCellModel)
        return DMXW.SdtCellConverter.CompareModelElement(sdtCell, sdtCellModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlCell customXmlCell && model is DMW.CustomXmlCell customXmlCellModel)
        return DMXW.CustomXmlCellConverter.CompareModelElement(customXmlCell, customXmlCellModel, diffs, objName);

      if (model is DMW.ICommonElement commonElementModel)
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
  /// Creates a SdtContentCell element item based on a model element.
  /// </summary>
  /// <param name="model">A model element with valid content.</param>
  /// <returns>Newly created openXml element</returns>
  /// <exception cref="InvalidOperationException">Thrown if a model element type is not recognized.</exception>
  public static OpenXmlElement CreateSdtContentCellOpenXmlElement(IModelElement model)
  {
    if (model is DMW.TableCell tableCell)
      return DMXW.TableCellConverter.CreateOpenXmlElement(tableCell);
    if (model is DMW.SdtCell sdtCell)
      return DMXW.SdtCellConverter.CreateOpenXmlElement(sdtCell);
    if (model is DMW.CustomXmlCell customXmlCell)
      return DMXW.CustomXmlCellConverter.CreateOpenXmlElement(customXmlCell);

    var result = CommonMarkersConverter.CreateOpenXmlElement(model as DMW.ICommonElement);
    if (result != null) return result;
    throw new InvalidOperationException($"Value of type \"{model.GetType()}\" not supported in SdtCellConverter.CreateOpenXmlParagraphElement method");
  }

  /// <summary>
  /// Updates a SdtContentCell element item based on a model element.
  /// </summary>
  /// <param name="openXmlElement">An openXml element to update.</param>
  /// <param name="model">A model element with valid content.</param>
  /// <returns><c>True</c> if the openXml element was updated succesfully, <c>false</c> otherwise</returns>
  public static bool UpdateSdtContentCellOpenXmlElement(DX.OpenXmlElement openXmlElement, IModelElement model)
  {
    if (openXmlElement is DXW.Paragraph paragraph && model is DMW.Paragraph paragraphModel)
      return DMXW.ParagraphConverter.UpdateOpenXmlElement(paragraph, paragraphModel);
    if (openXmlElement is DXW.Table table && model is DMW.Table tableModel)
      return DMXW.TableConverter.UpdateOpenXmlElement(table, tableModel);
    if (openXmlElement is DXW.SdtCell sdtCell && model is DMW.SdtCell sdtCellModel)
      return DMXW.SdtCellConverter.UpdateOpenXmlElement(sdtCell, sdtCellModel);
    if (openXmlElement is DXW.CustomXmlCell customXmlCell && model is DMW.CustomXmlCell customXmlCellModel)
      return DMXW.CustomXmlCellConverter.UpdateOpenXmlElement(customXmlCell, customXmlCellModel);
    return false;
  }

  #endregion


  #region StdCell conversion

  /// <summary>
  /// Creates a model element for a SdtCell element.
  /// </summary>
  /// <param name="openXmlElement">SdtBlock element read from DocumentFormat.OpenXml document</param>
  /// <returns>Newly created model element (or <c>null</c> if openXml element is <c>null</c>).</returns>
  public static DMW.SdtCell? CreateModelElement(DXW.SdtCell? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.SdtCell();
      model.SdtProperties = SdtElementConverter.GetSdtProperties(openXmlElement);
      model.SdtEndCharProperties = SdtElementConverter.GetSdtEndCharProperties(openXmlElement);
      ElementCollectionConverter<DMW.ISdtCellElement>.FillModelElementCollection(openXmlElement.SdtContentCell, model, 
        (CreateModelElementMethod)CreateSdtContentCellModelElement);
      return model;
    }
    return null;
  }

  /// <summary>
  /// Compares a SdtCell openXml element and a SdtCell model element that was created from that openXml element.
  /// </summary>
  /// <param name="openXmlElement">An openXml element read from DocumentFormat.OpenXml document.</param>
  /// <param name="model">A model element created from the openXml element.</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the model element is equivalent to openXml element, <c>false</c> otherwise</returns>
  public static bool CompareModelElement(DXW.SdtCell? openXmlElement, DMW.SdtCell? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!SdtElementConverter.CmpSdtProperties(openXmlElement, model.SdtProperties, diffs, objName))
        ok = false;
      if (!SdtElementConverter.CmpSdtEndCharProperties(openXmlElement, model.SdtEndCharProperties, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DMW.ISdtCellElement>.CompareOpenXmlElementCollection(openXmlElement.SdtContentCell, model,
        (CompareOpenXmlElementMethod)CompareSdtContentCellElement, diffs, objName))
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  /// <summary>
  /// Creates a SdtCell openXml element based on a SdtCell model element.
  /// </summary>
  /// <param name="model">A model element with valid content.</param>
  /// <returns>Newly created openXml element</returns>

  public static DXW.SdtCell CreateOpenXmlElement(DMW.SdtCell value)
  {
    var openXmlElement = new DXW.SdtCell();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  /// <summary>
  /// Updates a SdtCell element based on a SdtCell model element.
  /// </summary>
  /// <param name="openXmlElement">An openXml element to update.</param>
  /// <param name="model">A model element with valid content.</param>
  /// <returns><c>True</c> if the openXml element was updated succesfully, <c>false</c> otherwise</returns>

  public static bool UpdateOpenXmlElement(DXW.SdtCell openXmlElement, DMW.SdtCell model)
  {
    SdtElementConverter.SetSdtProperties(openXmlElement, model.SdtProperties);
    SdtElementConverter.SetSdtEndCharProperties(openXmlElement, model.SdtEndCharProperties);
    return ElementCollectionConverter<DMW.ISdtCellElement>.UpdateOpenXmlElementCollection(openXmlElement, model,
      (CompareOpenXmlElementMethod)CompareSdtContentCellElement,
      (UpdateOpenXmlElementMethod)UpdateSdtContentCellOpenXmlElement,
      (CreateOpenXmlElementMethod)CreateSdtContentCellOpenXmlElement);
  }
  #endregion

}
