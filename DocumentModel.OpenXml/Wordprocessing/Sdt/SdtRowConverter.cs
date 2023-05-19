using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Row-Level Structured Document Tag.
/// </summary>
public static class SdtRowConverter
{
  #region SdtContentRow elements conversion

    /// <summary>
  /// Creates item model element for SdtContentRow element item
  /// </summary>
  /// <param name="openXmlElement">Item element of SdtContentRow element</param>
  /// <returns>Newly created model element (or <c>null</c> if openXml element is <c>null</c>).</returns>
  /// <exception cref="InvalidOperationException">Thrown if openXml element type is not recognized.</exception>
  public static DMW.ISdtRowContent? CreateSdtContentRowModelElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.TableRow tableRow)
      return DMXW.TableRowConverter.CreateModelElement(tableRow);
    if (openXmlElement is DXW.SdtRow sdtRow)
      return DMXW.SdtRowConverter.CreateModelElement(sdtRow);
    if (openXmlElement is DXW.CustomXmlRow customXmlRow)
      return DMXW.CustomXmlRowConverter.CreateModelElement(customXmlRow);

    var model = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (model != null)
      return model;
    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in SdtRowConverter.CreateModelElement method");
    return null;
  }

  /// <summary>
  /// Compares SdtContentRow element item with a model element that was created from that openXml element
  /// </summary>
  /// <param name="openXmlElement">Item element of SdtContentRow element</param>
  /// <param name="model">A model element collection created from that openXmlElement.</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the model element is equivalent to the openXmlElement, <c>false</c> otherwise</returns>
  public static bool CompareSdtContentRowElement(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, 
    DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.TableRow tableRow && model is DMW.TableRow tableRowModel)
        return DMXW.TableRowConverter.CompareModelElement(tableRow, tableRowModel, diffs, objName);
      if (openXmlElement is DXW.SdtRow sdtRow && model is DMW.SdtRow sdtRowModel)
        return DMXW.SdtRowConverter.CompareModelElement(sdtRow, sdtRowModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlRow customXmlRow && model is DMW.CustomXmlRow customXmlRowModel)
        return DMXW.CustomXmlRowConverter.CompareModelElement(customXmlRow, customXmlRowModel, diffs, objName);

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
  /// Creates a SdtContentRow element item based on a model element.
  /// </summary>
  /// <param name="model">A model element with valid content.</param>
  /// <returns>Newly created openXml element</returns>
  /// <exception cref="InvalidOperationException">Thrown if a model element type is not recognized.</exception>
  public static OpenXmlElement CreateSdtContentRowOpenXmlElement(IModelElement model)
  {
    if (model is DMW.TableRow tableRow)
      return DMXW.TableRowConverter.CreateOpenXmlElement(tableRow);
    if (model is DMW.SdtRow sdtRow)
      return DMXW.SdtRowConverter.CreateOpenXmlElement(sdtRow);
    if (model is DMW.CustomXmlRow customXmlRow)
      return DMXW.CustomXmlRowConverter.CreateOpenXmlElement(customXmlRow);

    var result = CommonMarkersConverter.CreateOpenXmlElement(model as DMW.ICommonContent);
    if (result != null) return result;
    throw new InvalidOperationException($"Type of type \"{model.GetType()}\" not supported in SdtRowConverter.CreateOpenXmlParagraphContent method");
  }

  /// <summary>
  /// Updates a SdtContentRow element item based on a model element.
  /// </summary>
  /// <param name="openXmlElement">An openXml element to update.</param>
  /// <param name="model">A model element with valid content.</param>
  /// <returns><c>True</c> if the openXml element was updated succesfully, <c>false</c> otherwise</returns>
  public static bool UpdateSdtContentRowOpenXmlElement(DX.OpenXmlElement openXmlElement, IModelElement model)
  {
    if (openXmlElement is DXW.Paragraph paragraph && model is DMW.Paragraph paragraphModel)
      return DMXW.ParagraphConverter.UpdateOpenXmlElement(paragraph, paragraphModel);
    if (openXmlElement is DXW.Table table && model is DMW.Table tableModel)
      return DMXW.TableConverter.UpdateOpenXmlElement(table, tableModel);
    if (openXmlElement is DXW.SdtRow sdtRow && model is DMW.SdtRow sdtRowModel)
      return DMXW.SdtRowConverter.UpdateOpenXmlElement(sdtRow, sdtRowModel);
    if (openXmlElement is DXW.CustomXmlRow customXmlRow && model is DMW.CustomXmlRow customXmlRowModel)
      return DMXW.CustomXmlRowConverter.UpdateOpenXmlElement(customXmlRow, customXmlRowModel);
    return false;
  }

  #endregion


  #region StdRow conversion

  /// <summary>
  /// Creates a model element for a SdtRow element.
  /// </summary>
  /// <param name="openXmlElement">SdtBlock element read from DocumentFormat.OpenXml document</param>
  /// <returns>Newly created model element (or <c>null</c> if openXml element is <c>null</c>).</returns>
  public static DMW.SdtRow? CreateModelElement(DXW.SdtRow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.SdtRow();
      model.SdtProperties = SdtElementConverter.GetSdtProperties(openXmlElement);
      model.SdtEndCharProperties = SdtElementConverter.GetSdtEndCharProperties(openXmlElement);
      ElementCollectionConverter<DMW.ISdtRowContent>.FillModelElementCollection(openXmlElement.SdtContentRow, model,
        CreateSdtContentRowModelElement);
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
  public static bool CompareModelElement(DXW.SdtRow? openXmlElement, DMW.SdtRow? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!SdtElementConverter.CmpSdtProperties(openXmlElement, model.SdtProperties, diffs, objName))
        ok = false;
      if (!SdtElementConverter.CmpSdtEndCharProperties(openXmlElement, model.SdtEndCharProperties, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DMW.ISdtRowContent>.CompareOpenXmlElementCollection(openXmlElement.SdtContentRow, model,
        CompareSdtContentRowElement, diffs, objName))
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  /// <summary>
  /// Creates a SdtRow openXml element based on a SdtRow model element.
  /// </summary>
  /// <param name="model">A model element with valid content.</param>
  /// <returns>Newly created openXml element</returns>

  public static DXW.SdtRow CreateOpenXmlElement(DMW.SdtRow value)
  {
    var openXmlElement = new DXW.SdtRow();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  /// <summary>
  /// Updates a SdtRow element based on a SdtRow model element.
  /// </summary>
  /// <param name="openXmlElement">An openXml element to update.</param>
  /// <param name="model">A model element with valid content.</param>
  /// <returns><c>True</c> if the openXml element was updated succesfully, <c>false</c> otherwise</returns>

  public static bool UpdateOpenXmlElement(DXW.SdtRow openXmlElement, DMW.SdtRow model)
  {
    SdtElementConverter.SetSdtProperties(openXmlElement, model.SdtProperties);
    SdtElementConverter.SetSdtEndCharProperties(openXmlElement, model.SdtEndCharProperties);
    return ElementCollectionConverter<DMW.ISdtRowContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      CompareSdtContentRowElement,
      UpdateSdtContentRowOpenXmlElement,
      CreateSdtContentRowOpenXmlElement);
  }
  #endregion
}
