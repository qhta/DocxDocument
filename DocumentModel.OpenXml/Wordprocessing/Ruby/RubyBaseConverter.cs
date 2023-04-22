namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.RubyBase"/> class from/to OpenXml converter.
/// </summary>
public static class RubyBaseConverter
{
  #region StdRun model conversion.

  /// <summary>
  /// Creates a model element for a RubyBase element.
  /// </summary>
  /// <param name="openXmlElement">SdtBlock element read from DocumentFormat.OpenXml document</param>
  /// <returns>Newly created model element (or <c>null</c> if openXml element is <c>null</c>).</returns>
  public static DMW.RubyBase? CreateModelElement(DXW.RubyBase? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.RubyBase();
      ElementCollectionConverter<DMW.IRubyContent>.FillModelElementCollection(openXmlElement, model,
        RubyContentConverter.CreateRubyContentModelElement);
      return model;
    }
    return null;
  }

  /// <summary>
  /// Compares a RubyBase openXml element and a RubyBase model element that was created from that openXml element.
  /// </summary>
  /// <param name="openXmlElement">An openXml element read from DocumentFormat.OpenXml document.</param>
  /// <param name="model">A model element created from the openXml element.</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the model element is equivalent to openXml element, <c>false</c> otherwise</returns>
  public static bool CompareModelElement(DXW.RubyBase? openXmlElement, DMW.RubyBase? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!ElementCollectionConverter<DMW.IRubyContent>.CompareOpenXmlElementCollection(openXmlElement, model,
        RubyContentConverter.CompareRubyContentElement, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  /// <summary>
  /// Creates a RubyBase openXml element based on a RubyBase model element.
  /// </summary>
  /// <param name="model">A model element with valid content.</param>
  /// <returns>Newly created openXml element</returns>

  public static DXW.RubyBase CreateOpenXmlElement(DMW.RubyBase value)
  {
    var openXmlElement = new DXW.RubyBase();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  /// <summary>
  /// Updates a RubyBase element based on a RubyBase model element.
  /// </summary>
  /// <param name="openXmlElement">An openXml element to update.</param>
  /// <param name="model">A model element with valid content.</param>
  /// <returns><c>True</c> if the openXml element was updated succesfully, <c>false</c> otherwise</returns>

  public static bool UpdateOpenXmlElement(DXW.RubyBase openXmlElement, DMW.RubyBase model)
  {
    return ElementCollectionConverter<DMW.IRubyContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      RubyContentConverter.CompareRubyContentElement,
      RubyContentConverter.UpdateRubyContentOpenXmlElement,
      RubyContentConverter.CreateRubyContentOpenXmlElement);
  }
  #endregion

}
