namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Inline-Level Structured Document Tag Content.
/// </summary>
public static class SdtContentRunConverter
{
  private static DMMath.Run? GetRun(DXW.SdtContentRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Run>();
    if (element != null)
      return DMXMath.RunConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpRun(DXW.SdtContentRun openXmlElement, DMMath.Run? value, DiffList? diffs, string? objName)
  {
    return DMXMath.RunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Run>(), value, diffs, objName);
  }

  private static void SetRun(DXW.SdtContentRun openXmlElement, DMMath.Run? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Run>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.RunConverter.CreateOpenXmlElement<DXMath.Run>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  private static DMW.CustomXmlRun? GetCustomXmlRun(DXW.SdtContentRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlRun>();
    if (element != null)
      return DMXW.CustomXmlRunConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpCustomXmlRun(DXW.SdtContentRun openXmlElement, DMW.CustomXmlRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.CustomXmlRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlRun>(), value, diffs, objName);
  }

  private static void SetCustomXmlRun(DXW.SdtContentRun openXmlElement, DMW.CustomXmlRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CustomXmlRunConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  private static Collection<DMW.SimpleField>? GetSimpleFields(DXW.SdtContentRun openXmlElement)
  {
    var collection = new Collection<DMW.SimpleField>();
    foreach (var item in openXmlElement.Elements<DXW.SimpleField>())
    {
      var newItem = DMXW.SimpleFieldConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count > 0)
      return collection;
    return null;
  }

  private static bool CmpSimpleFields(DXW.SdtContentRun openXmlElement, Collection<DMW.SimpleField>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXW.SimpleField>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name + ".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXW.SimpleFieldConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  private static void SetSimpleFields(DXW.SdtContentRun openXmlElement, Collection<DMW.SimpleField>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.SimpleField>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.SimpleFieldConverter.CreateOpenXmlElement(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }

  private static DMW.Hyperlink? GetHyperlink(DXW.SdtContentRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Hyperlink>();
    if (element != null)
      return DMXW.HyperlinkConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpHyperlink(DXW.SdtContentRun openXmlElement, DMW.Hyperlink? value, DiffList? diffs, string? objName)
  {
    return DMXW.HyperlinkConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Hyperlink>(), value, diffs, objName);
  }

  private static void SetHyperlink(DXW.SdtContentRun openXmlElement, DMW.Hyperlink? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Hyperlink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.HyperlinkConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  private static DMW.SdtRun? GetSdtRun(DXW.SdtContentRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SdtRun>();
    if (element != null)
      return DMXW.SdtRunConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpSdtRun(DXW.SdtContentRun openXmlElement, DMW.SdtRun? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtRunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtRun>(), value, diffs, objName);
  }

  private static void SetSdtRun(DXW.SdtContentRun openXmlElement, DMW.SdtRun? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtRun>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtRunConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  private static DMW.BidirectionalOverride? GetBidirectionalOverride(DXW.SdtContentRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BidirectionalOverride>();
    if (element != null)
      return DMXW.BidirectionalOverrideConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpBidirectionalOverride(DXW.SdtContentRun openXmlElement, DMW.BidirectionalOverride? value, DiffList? diffs, string? objName)
  {
    return DMXW.BidirectionalOverrideConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BidirectionalOverride>(), value, diffs, objName);
  }

  private static void SetBidirectionalOverride(DXW.SdtContentRun openXmlElement, DMW.BidirectionalOverride? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BidirectionalOverride>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BidirectionalOverrideConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  private static DMW.BidirectionalEmbedding? GetBidirectionalEmbedding(DXW.SdtContentRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.BidirectionalEmbedding>();
    if (element != null)
      return DMXW.BidirectionalEmbeddingConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpBidirectionalEmbedding(DXW.SdtContentRun openXmlElement, DMW.BidirectionalEmbedding? value, DiffList? diffs, string? objName)
  {
    return DMXW.BidirectionalEmbeddingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.BidirectionalEmbedding>(), value, diffs, objName);
  }

  private static void SetBidirectionalEmbedding(DXW.SdtContentRun openXmlElement, DMW.BidirectionalEmbedding? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BidirectionalEmbedding>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BidirectionalEmbeddingConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  private static DMW.RelationshipType? GetSubDocumentReference(DXW.SdtContentRun openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SubDocumentReference>();
    if (element != null)
      return DMXW.RelationshipTypeConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpSubDocumentReference(DXW.SdtContentRun openXmlElement, DMW.RelationshipType? value, DiffList? diffs, string? objName)
  {
    return DMXW.RelationshipTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SubDocumentReference>(), value, diffs, objName);
  }

  private static void SetSubDocumentReference(DXW.SdtContentRun openXmlElement, DMW.RelationshipType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SubDocumentReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RelationshipTypeConverter.CreateOpenXmlElement<DXW.SubDocumentReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }

  #region SdtContentRun elements conversion
  public static DMW.ISdtRunElement? CreateSdtContentRunElement(DX.OpenXmlElement? openXmlElement)
  {
    var commonRunElement = CommonRunConverter.CreateModelElement(openXmlElement);
    if (commonRunElement != null)
      return commonRunElement;

    var commonMarker = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (commonMarker != null)
      return commonMarker;

    var commonMathElement = CommonMathConverter.CreateModelElement(openXmlElement);
    if (commonMathElement != null)
      return commonMathElement;

    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in ParagraphConverter.CreateModelElement method");
    return null;
  }

  public static bool CompareParagraphElement(DX.OpenXmlElement? openXmlElement, DMW.IParagraphElement? value, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && value != null)
    {
      if (value is DMW.ICommonRunElement commonRunElementModel)
      {
        var result = CommonRunConverter.CompareModelElement(openXmlElement, commonRunElementModel, diffs, objName);
        if (result != null)
          return (bool)result;
      }

      if (value is DMW.ICommonElement commonElementModel)
      {
        var result = CommonMarkersConverter.CompareModelElement(openXmlElement, commonElementModel, diffs, objName);
        if (result != null)
          return (bool)result;
      }
      if (value is DMMath.ICommonMathElement commonMathElementModel)
      {
        var result = CommonMathConverter.CompareModelElement(openXmlElement, commonMathElementModel, diffs, objName);
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

  public static OpenXmlElement CreateOpenXmlElement(DMW.IParagraphElement value)
  {
    if (value is DMW.ICommonRunElement commonRunElementModel)
    {
      var commonRunElement = CommonRunConverter.CreateOpenXmlElement(commonRunElementModel);
      if (commonRunElement != null) return commonRunElement;
    }

    if (value is DMW.ICommonElement commonElementModel)
    {
      var commonMarker = CommonMarkersConverter.CreateOpenXmlElement(commonElementModel);
      if (commonMarker != null) return commonMarker;
    }

    if (value is DMMath.ICommonMathElement commonMathElementModel)
    {
      var commonMathElement = CommonMathConverter.CreateOpenXmlElement(commonMathElementModel);
      if (commonMathElement != null) return commonMathElement;
    }

    throw new InvalidOperationException($"Value of type \"{value.GetType()}\" not supported in ParagraphConverter.CreateOpenXmlElement method");
  }
  #endregion


  public static DMW.SdtContentRun? CreateModelElement(DXW.SdtContentRun? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtContentRun();
      value.Run = GetRun(openXmlElement);
      value.CustomXmlRun = GetCustomXmlRun(openXmlElement);
      value.SimpleFields = GetSimpleFields(openXmlElement);
      value.Hyperlink = GetHyperlink(openXmlElement);
      value.SdtRun = GetSdtRun(openXmlElement);
      value.BidirectionalOverride = GetBidirectionalOverride(openXmlElement);
      value.BidirectionalEmbedding = GetBidirectionalEmbedding(openXmlElement);
      value.SubDocumentReference = GetSubDocumentReference(openXmlElement);

      return value;
    }
    return null;
  }

  #region SdtContentRun conversion
  public static bool CompareModelElement(DXW.SdtContentRun? openXmlElement, DMW.SdtContentRun? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRun(openXmlElement, value.Run, diffs, objName))
        ok = false;
      if (!CmpCustomXmlRun(openXmlElement, value.CustomXmlRun, diffs, objName))
        ok = false;
      if (!CmpSimpleFields(openXmlElement, value.SimpleFields, diffs, objName))
        ok = false;
      if (!CmpHyperlink(openXmlElement, value.Hyperlink, diffs, objName))
        ok = false;
      if (!CmpSdtRun(openXmlElement, value.SdtRun, diffs, objName))
        ok = false;
      if (!CmpBidirectionalOverride(openXmlElement, value.BidirectionalOverride, diffs, objName))
        ok = false;
      if (!CmpBidirectionalEmbedding(openXmlElement, value.BidirectionalEmbedding, diffs, objName))
        ok = false;
      if (!CmpSubDocumentReference(openXmlElement, value.SubDocumentReference, diffs, objName))
        ok = false;

      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static DXW.SdtContentRun CreateOpenXmlElement(DMW.SdtContentRun value)
  {
    var openXmlElement = new DXW.SdtContentRun();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.SdtContentRun openXmlElement, DMW.SdtContentRun value)
  {
    SetRun(openXmlElement, value?.Run);
    SetCustomXmlRun(openXmlElement, value?.CustomXmlRun);
    SetSimpleFields(openXmlElement, value?.SimpleFields);
    SetHyperlink(openXmlElement, value?.Hyperlink);
    SetSdtRun(openXmlElement, value?.SdtRun);
    SetBidirectionalOverride(openXmlElement, value?.BidirectionalOverride);
    SetBidirectionalEmbedding(openXmlElement, value?.BidirectionalEmbedding);
    SetSubDocumentReference(openXmlElement, value?.SubDocumentReference);
  }
  #endregion
}