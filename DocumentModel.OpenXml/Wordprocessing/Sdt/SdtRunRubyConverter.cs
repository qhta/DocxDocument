namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="SdtRunRubyConverter"/> class from/to OpenXml converter.
/// </summary>
public static class SdtRunRubyConverter
{
  #region StdRun model conversion.

  /// <summary>
  /// Creates a model element for a SdtRunRuby element.
  /// </summary>
  /// <param name="openXmlElement">SdtBlock element read from DocumentFormat.OpenXml document</param>
  /// <returns>Newly created model element (or <c>null</c> if openXml element is <c>null</c>).</returns>
  public static DMW.SdtRunRuby? CreateModelElement(DXW.SdtRunRuby? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.SdtRunRuby();
      model.SdtProperties = SdtElementConverter.GetSdtProperties(openXmlElement);
      model.SdtEndCharProperties = SdtElementConverter.GetSdtEndCharProperties(openXmlElement);
      ElementCollectionConverter<DMW.IRubyContent>.FillModelElementCollection(openXmlElement.SdtContentRunRuby, model,
        RubyContentConverter.CreateRubyContentModelElement);
      return model;
    }
    return null;
  }

  /// <summary>
  /// Compares a SdtRunRuby openXml element and a SdtRunRuby model element that was created from that openXml element.
  /// </summary>
  /// <param name="openXmlElement">An openXml element read from DocumentFormat.OpenXml document.</param>
  /// <param name="model">A model element created from the openXml element.</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the model element is equivalent to openXml element, <c>false</c> otherwise</returns>
  public static bool CompareModelElement(DXW.SdtRunRuby? openXmlElement, DMW.SdtRunRuby? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!SdtElementConverter.CmpSdtProperties(openXmlElement, model.SdtProperties, diffs, objName))
        ok = false;
      if (!SdtElementConverter.CmpSdtEndCharProperties(openXmlElement, model.SdtEndCharProperties, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DMW.IRubyContent>.CompareOpenXmlElementCollection(openXmlElement.SdtContentRunRuby, model,
        RubyContentConverter.CompareRubyContentElement, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  /// <summary>
  /// Creates a SdtRunRuby openXml element based on a SdtRunRuby model element.
  /// </summary>
  /// <param name="model">A model element with valid content.</param>
  /// <returns>Newly created openXml element</returns>

  public static DXW.SdtRunRuby CreateOpenXmlElement(DMW.SdtRunRuby value)
  {
    var openXmlElement = new DXW.SdtRunRuby();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  /// <summary>
  /// Updates a SdtRunRuby element based on a SdtRunRuby model element.
  /// </summary>
  /// <param name="openXmlElement">An openXml element to update.</param>
  /// <param name="model">A model element with valid content.</param>
  /// <returns><c>True</c> if the openXml element was updated succesfully, <c>false</c> otherwise</returns>

  public static bool UpdateOpenXmlElement(DXW.SdtRunRuby openXmlElement, DMW.SdtRunRuby model)
  {
    SdtElementConverter.SetSdtProperties(openXmlElement, model.SdtProperties);
    SdtElementConverter.SetSdtEndCharProperties(openXmlElement, model.SdtEndCharProperties);
    return ElementCollectionConverter<DMW.IRubyContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      RubyContentConverter.CompareRubyContentElement,
      RubyContentConverter.UpdateRubyContentOpenXmlElement,
      RubyContentConverter.CreateRubyContentOpenXmlElement);
  }
  #endregion

}
