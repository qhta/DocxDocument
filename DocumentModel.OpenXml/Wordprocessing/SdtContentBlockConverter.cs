namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Block-Level Structured Document Tag Content.
/// </summary>
public static class SdtContentBlockConverter
{

  #region SdtContentBlock elements conversion
  public static DMW.ISdtBlockElement? CreateSdtContentBlockElement(DX.OpenXmlElement? openXmlElement)
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

  public static bool CompareSdtContentBlockElement(DX.OpenXmlElement? openXmlElement, DMW.ISdtBlockElement? value, DiffList? diffs = null, string? objName = null)
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
      diffs?.Add(objName, "Type", openXmlElement.GetType().Name, value.GetType().Name);
      return false;
     }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElement CreateOpenXmlElement(DMW.ISdtBlockElement value)
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
  #endregion

  #region StdContentBlock conversion
  public static DMW.SdtContentBlock? CreateModelElement(DXW.SdtContentBlock? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtContentBlock();
      var elements = openXmlElement.Elements().ToArray();
      foreach (var element in elements)
      {
        var item = CreateSdtContentBlockElement(element);
        if (item != null)
          value.Add(item);
      }
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SdtContentBlock? openXmlElement, DMW.SdtContentBlock? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      var sdtBlockItems = value.ToArray();
      var elements = openXmlElement.Elements().ToArray();
      for (int i = 0; i < System.Math.Min(sdtBlockItems.Count(), elements.Count()); i++)
      {
        var element = elements[i];
        var item = sdtBlockItems[i];
        if (!CompareSdtContentBlockElement(element, item, diffs, objName))
          ok = false;
      }
      if (!Int32ValueConverter.CmpValue(elements.Count(), sdtBlockItems.Count(), diffs, objName, "SdtContentBlock.Items.Count"))
        ok = false;

      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.SdtContentBlock CreateOpenXmlElement(DMW.SdtContentBlock value)
  {
    var openXmlElement = new DXW.SdtContentBlock();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.SdtContentBlock openXmlElement, DMW.SdtContentBlock value)
  {
    var sdtContentBlockItems = value.ToArray();
    var elements = openXmlElement.Elements();
    var elementsEnumerator = elements.GetEnumerator();
    for (int i = 0; i < sdtContentBlockItems.Count(); i++)
    {
      var item = sdtContentBlockItems[i];
      OpenXmlElement? element = elementsEnumerator.MoveNext() ? elementsEnumerator.Current : null;
      if (element == null)
      {
        element = CreateOpenXmlElement(item);
        openXmlElement.AddChild(element);
      }
    }
  }
  #endregion
}
