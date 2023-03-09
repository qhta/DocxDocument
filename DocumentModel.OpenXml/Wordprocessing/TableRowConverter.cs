namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Row.
/// </summary>
public static class TableRowConverter
{
  #region Revision Identifier for Table Row Glyph Formatting conversion
  private static DM.HexInt? GetRsidTableRowMarkRevision(DXW.TableRow openXmlElement)
  {
    if (openXmlElement?.RsidTableRowMarkRevision?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidTableRowMarkRevision.Value);
    return null;
  }

  private static bool CmpRsidTableRowMarkRevision(DXW.TableRow openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidTableRowMarkRevision?.Value, value, diffs, objName, "RsidTableRowMarkRevision");
  }

  private static void SetRsidTableRowMarkRevision(DXW.TableRow openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidTableRowMarkRevision = value.ToString();
    else
      openXmlElement.RsidTableRowMarkRevision = null;
  }
  #endregion

  #region Revision Identifier for Table Row conversion
  private static DM.HexInt? GetRsidTableRowAddition(DXW.TableRow openXmlElement)
  {
    if (openXmlElement?.RsidTableRowAddition?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidTableRowAddition.Value);
    return null;
  }

  private static bool CmpRsidTableRowAddition(DXW.TableRow openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidTableRowAddition?.Value, value, diffs, objName, "RsidTableRowAddition");
  }

  private static void SetRsidTableRowAddition(DXW.TableRow openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidTableRowAddition = value.ToString();
    else
      openXmlElement.RsidTableRowAddition = null;
  }
  #endregion

  #region Revision Identifier for Table Row Deletion conversion
  private static DM.HexInt? GetRsidTableRowDeletion(DXW.TableRow openXmlElement)
  {
    if (openXmlElement?.RsidTableRowDeletion?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidTableRowDeletion.Value);
    return null;
  }

  private static bool CmpRsidTableRowDeletion(DXW.TableRow openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidTableRowDeletion?.Value, value, diffs, objName, "RsidTableRowDeletion");
  }

  private static void SetRsidTableRowDeletion(DXW.TableRow openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidTableRowDeletion = value.ToString();
    else
      openXmlElement.RsidTableRowDeletion = null;
  }
  #endregion

  #region Revision Identifier for Table Row Properties conversion
  private static DM.HexInt? GetRsidTableRowProperties(DXW.TableRow openXmlElement)
  {
    if (openXmlElement?.RsidTableRowProperties?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.RsidTableRowProperties.Value);
    return null;
  }

  private static bool CmpRsidTableRowProperties(DXW.TableRow openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.RsidTableRowProperties?.Value, value, diffs, objName, "RsidTableRowProperties");
  }

  private static void SetRsidTableRowProperties(DXW.TableRow openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.RsidTableRowProperties = value.ToString();
    else
      openXmlElement.RsidTableRowProperties = null;
  }
  #endregion

  #region ParagraphId conversion
  private static DM.HexInt? GetParagraphId(DXW.TableRow openXmlElement)
  {
    if (openXmlElement?.ParagraphId?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.ParagraphId.Value);
    return null;
  }

  private static bool CmpParagraphId(DXW.TableRow openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.ParagraphId?.Value, value, diffs, objName, "ParagraphId");
  }

  private static void SetParagraphId(DXW.TableRow openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.ParagraphId = value.ToString();
    else
      openXmlElement.ParagraphId = null;
  }
  #endregion

  #region TextId conversion
  /// <summary>
  /// textId, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.HexInt? GetTextId(DXW.TableRow openXmlElement)
  {
    if (openXmlElement?.TextId?.Value != null)
      return HexIntConverter.GetValue(openXmlElement.TextId.Value);
    return null;
  }

  private static bool CmpTextId(DXW.TableRow openXmlElement, DM.HexInt? value, DiffList? diffs, string? objName)
  {
    return HexIntConverter.CmpValue(openXmlElement?.TextId?.Value, value, diffs, objName, "TextId");
  }

  private static void SetTextId(DXW.TableRow openXmlElement, DM.HexInt? value)
  {
    if (value != null)
      openXmlElement.TextId = value.ToString();
    else
      openXmlElement.TextId = null;
  }
  #endregion

  #region Table-Level Property Exceptions conversion
  private static DMW.TablePropertyExceptions? GetTablePropertyExceptions(DXW.TableRow openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TablePropertyExceptions>();
    if (element != null)
      return DMXW.TablePropertyExceptionsConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpTablePropertyExceptions(DXW.TableRow openXmlElement, DMW.TablePropertyExceptions? value, DiffList? diffs, string? objName)
  {
    return DMXW.TablePropertyExceptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TablePropertyExceptions>(), value, diffs, objName);
  }

  private static void SetTablePropertyExceptions(DXW.TableRow openXmlElement, DMW.TablePropertyExceptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TablePropertyExceptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TablePropertyExceptionsConverter.CreateOpenXmlElement<DXW.TablePropertyExceptions>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region TableRowProperties conversion
  private static DMW.TableRowProperties? GetTableRowProperties(DXW.TableRow openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableRowProperties>();
    if (element != null)
      return DMXW.TableRowPropertiesConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpTableRowProperties(DXW.TableRow openXmlElement, DMW.TableRowProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableRowPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableRowProperties>(), value, diffs, objName);
  }

  private static void SetTableRowProperties(DXW.TableRow openXmlElement, DMW.TableRowProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableRowProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableRowPropertiesConverter.CreateOpenXmlElement<DXW.TableRowProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region TableRow elements conversion
  public static DMW.ITableRowElement? CreateTableRowElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.TableCell tableCell)
      return DMXW.TableCellConverter.CreateModelElement(tableCell);
    if (openXmlElement is DXW.SdtCell sdtCell)
      return DMXW.SdtCellConverter.CreateModelElement(sdtCell);
    if (openXmlElement is DXW.CustomXmlCell customXmlCell)
      return DMXW.CustomXmlCellConverter.CreateModelElement(customXmlCell);

    var result = CommonMarkersConverter.CreateModelElement(openXmlElement);
    if (result != null)
      return result;
    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in TableRowConverter.CreateModelElement method");
    return null;
  }

  public static bool CompareTableRowElement(DX.OpenXmlElement? openXmlElement, DMW.ITableRowElement? value, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement != null && value != null)
    {
      if (openXmlElement is DXW.TableCell tableCell && value is DMW.TableCell tableCellModel)
        return DMXW.TableCellConverter.CompareModelElement(tableCell, tableCellModel, diffs, objName);
      if (openXmlElement is DXW.SdtCell sdtCell && value is DMW.SdtCell sdtCellModel)
        return DMXW.SdtCellConverter.CompareModelElement(sdtCell, sdtCellModel, diffs, objName);
      if (openXmlElement is DXW.CustomXmlCell customXmlCell && value is DMW.CustomXmlCell customXmlCellModel)
        return DMXW.CustomXmlCellConverter.CompareModelElement(customXmlCell, customXmlCellModel, diffs, objName);

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

  public static OpenXmlElement CreateOpenXmlElement(DMW.ITableRowElement value)
  {
    if (value is DMW.TableCell tableCell)
      return DMXW.TableCellConverter.CreateOpenXmlElement(tableCell);
    if (value is DMW.SdtCell sdtCell)
      return DMXW.SdtCellConverter.CreateOpenXmlElement(sdtCell);
    if (value is DMW.CustomXmlCell customXmlCell)
      return DMXW.CustomXmlCellConverter.CreateOpenXmlElement(customXmlCell);

    var result = CommonMarkersConverter.CreateOpenXmlElement(value as DMW.ICommonElement);
    if (result != null) return result;
    throw new InvalidOperationException($"Value of type \"{value.GetType()}\" not supported in TableRowConverter.CreateOpenXmlElement method");
  }
  #endregion

  #region TableRow conversion
  public static DMW.TableRow? CreateModelElement(DXW.TableRow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableRow();
      value.RsidTableRowMarkRevision = GetRsidTableRowMarkRevision(openXmlElement);
      value.RsidTableRowAddition = GetRsidTableRowAddition(openXmlElement);
      value.RsidTableRowDeletion = GetRsidTableRowDeletion(openXmlElement);
      value.RsidTableRowProperties = GetRsidTableRowProperties(openXmlElement);
      value.ParagraphId = GetParagraphId(openXmlElement);
      value.TextId = GetTextId(openXmlElement);
      value.TablePropertyExceptions = GetTablePropertyExceptions(openXmlElement);
      value.TableRowProperties = GetTableRowProperties(openXmlElement);
      var elements = openXmlElement.Elements().ToArray();
      foreach (var element in elements)
      {
        if (element is DXW.TablePropertyExceptions)
          continue;
        if (element is DXW.TableRowProperties)
          continue;
        var item = CreateTableRowElement(element);
        if (item != null)
          value.Add(item);
      }

      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.TableRow? openXmlElement, DMW.TableRow? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRsidTableRowMarkRevision(openXmlElement, value.RsidTableRowMarkRevision, diffs, objName))
        ok = false;
      if (!CmpRsidTableRowAddition(openXmlElement, value.RsidTableRowAddition, diffs, objName))
        ok = false;
      if (!CmpRsidTableRowDeletion(openXmlElement, value.RsidTableRowDeletion, diffs, objName))
        ok = false;
      if (!CmpRsidTableRowProperties(openXmlElement, value.RsidTableRowProperties, diffs, objName))
        ok = false;
      if (!CmpParagraphId(openXmlElement, value.ParagraphId, diffs, objName))
        ok = false;
      if (!CmpTextId(openXmlElement, value.TextId, diffs, objName))
        ok = false;
      if (!CmpTablePropertyExceptions(openXmlElement, value.TablePropertyExceptions, diffs, objName))
        ok = false;
      if (!CmpTableRowProperties(openXmlElement, value.TableRowProperties, diffs, objName))
        ok = false;
      var tableRowItems = value.ToArray();
      var elements = openXmlElement.Elements().Where(item => !(item is DXW.TablePropertyExceptions) && !(item is DXW.TableRowProperties)).ToArray();
      for (int i = 0; i < System.Math.Min(tableRowItems.Count(), elements.Count()); i++)
      {
        var element = elements[i];
        var item = tableRowItems[i];
        if (!CompareTableRowElement(element, item, diffs, objName))
          ok = false;
      }
      if (!Int32ValueConverter.CmpValue(elements.Count(), tableRowItems.Count(), diffs, objName, "TableRow.Items.Count"))
        ok = false;

      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static DXW.TableRow CreateOpenXmlElement(DMW.TableRow value)
  {
    var openXmlElement = new DXW.TableRow();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.TableRow openXmlElement, DMW.TableRow value)
  {
    SetRsidTableRowMarkRevision(openXmlElement, value.RsidTableRowMarkRevision);
    SetRsidTableRowAddition(openXmlElement, value.RsidTableRowAddition);
    SetRsidTableRowDeletion(openXmlElement, value.RsidTableRowDeletion);
    SetRsidTableRowProperties(openXmlElement, value.RsidTableRowProperties);
    SetParagraphId(openXmlElement, value.ParagraphId);
    SetTextId(openXmlElement, value.TextId);
    SetTablePropertyExceptions(openXmlElement, value.TablePropertyExceptions);
    SetTableRowProperties(openXmlElement, value.TableRowProperties);
    var tableRowItems = value.ToArray();
    var elements = openXmlElement.Elements();
    var elementsEnumerator = elements.GetEnumerator();
    for (int i = 0; i < tableRowItems.Count(); i++)
    {
      var item = tableRowItems[i];
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
