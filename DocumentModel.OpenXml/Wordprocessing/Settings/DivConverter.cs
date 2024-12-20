namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Div"/> class from/to OpenXml converter.
/// </summary>
public static class DivConverter
{
  #region Id conversion.
  private static Int32? GetId(DXW.Div openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Id?.Value);
  }

  private static bool CmpId(DXW.Div openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return Int32ValueConverter.CmpValue(openXmlElement?.Id?.Value, value, diffs, objName, "Id");
  }

  private static void SetId(DXW.Div openXmlElement, Int32? value)
  {
    openXmlElement.Id = Int32ValueConverter.CreateStringValue(value);
  }
  #endregion

  #region BlockQuote conversion.
  private static Boolean? GetBlockQuote(DXW.Div openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BlockQuote>());
  }

  private static bool CmpBlockQuote(DXW.Div openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BlockQuote>(), value, diffs, objName, propName);
  }

  private static void SetBlockQuote(DXW.Div openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.BlockQuote>(openXmlElement, value, null, "1");
  }
  #endregion

  #region BodyDiv conversion.
  private static Boolean? GetBodyDiv(DXW.Div openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BodyDiv>());
  }

  private static bool CmpBodyDiv(DXW.Div openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BodyDiv>(), value, diffs, objName, propName);
  }

  private static void SetBodyDiv(DXW.Div openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.BodyDiv>(openXmlElement, value, null, "1");
  }
  #endregion

  #region LeftMargin conversion.
  private static Twips? GetLeftMarginDiv(DXW.Div openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.LeftMarginDiv>()?.Val);
  }

  private static bool CmpLeftMarginDiv(DXW.Div openXmlElement, Twips? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return Int32ValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.LeftMarginDiv>()?.Val, value, diffs, objName, "LeftMargin");
  }

  private static void SetLeftMarginDiv(DXW.Div openXmlElement, Twips? value)
  {
    Int32ValueConverter.SetValue<DXW.LeftMarginDiv>(openXmlElement, value);
  }
  #endregion

  #region RightMargin conversion.
  private static Twips? GetRightMarginDiv(DXW.Div openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.RightMarginDiv>()?.Val);
  }

  private static bool CmpRightMarginDiv(DXW.Div openXmlElement, Twips? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return Int32ValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.RightMarginDiv>()?.Val, value, diffs, objName, "RightMargin");
  }

  private static void SetRightMarginDiv(DXW.Div openXmlElement, Twips? value)
  {
    Int32ValueConverter.SetValue<DXW.RightMarginDiv>(openXmlElement, value);
  }
  #endregion

  #region TopMargin conversion.
  private static Twips? GetTopMarginDiv(DXW.Div openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.TopMarginDiv>()?.Val);
  }

  private static bool CmpTopMarginDiv(DXW.Div openXmlElement, Twips? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return Int32ValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.TopMarginDiv>()?.Val, value, diffs, objName, "TopMargin");
  }

  private static void SetTopMarginDiv(DXW.Div openXmlElement, Twips? value)
  {
    Int32ValueConverter.SetValue<DXW.TopMarginDiv>(openXmlElement, value);
  }
  #endregion

  #region  BottomMargin conversion.
  private static Twips? GetBottomMarginDiv(DXW.Div openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.BottomMarginDiv>()?.Val);
  }

  private static bool CmpBottomMarginDiv(DXW.Div openXmlElement, Twips? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return Int32ValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.BottomMarginDiv>()?.Val, value, diffs, objName, "BottomMargin");
  }

  private static void SetBottomMarginDiv(DXW.Div openXmlElement, Twips? value)
  {
    Int32ValueConverter.SetValue<DXW.BottomMarginDiv>(openXmlElement, value);
  }
  #endregion

  #region Border conversion.
  private static DMW.DivBorder? GetDivBorder(DXW.Div openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DivBorder>();
    if (element != null)
      return DMXW.DivBorderConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpDivBorder(DXW.Div openXmlElement, DMW.DivBorder? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.DivBorderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DivBorder>(), value, diffs, objName, propName);
  }

  private static void SetDivBorder(DXW.Div openXmlElement, DMW.DivBorder? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DivBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DivBorderConverter.CreateOpenXmlElement<DXW.DivBorder>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region DivsChild conversion.
  private static DM.IModelElement? GetDivsChild(DX.OpenXmlElement openXmlElement)
  {
    return DivsConverter.CreateModelElement(openXmlElement as DXW.DivsChild);
  }

  private static bool CmpDivsChild(DX.OpenXmlElement? openXmlElement, DM.IModelElement? value,
    DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DivsConverter.CompareModelElement(openXmlElement as DXW.DivsChild, value as DMW.Divs, diffs, objName, propName);
  }

  public static bool UpdateDivsChild(DX.OpenXmlElement openXmlElement, DM.IModelElement model)
  {
    if (openXmlElement is DXW.DivsChild divElement && model is DMW.Divs divModel)
      return DivsConverter.UpdateOpenXmlElement(divElement, divModel);
    return false;
  }

  public static OpenXmlElement CreateDivsChild(DM.IModelElement model)
  {
    if (model is DMW.Divs divModel)
      return DivsConverter.CreateOpenXmlElement<DXW.DivsChild>(divModel);
    return null!;
  }

  #endregion

  #region Div model conversion.
  public static DMW.Div? CreateModelElement(DXW.Div? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Div();
      model.Id = GetId(openXmlElement);
      model.IsBlockQuote = GetBlockQuote(openXmlElement);
      model.IsBody = GetBodyDiv(openXmlElement);
      model.LeftMargin = GetLeftMarginDiv(openXmlElement);
      model.RightMargin = GetRightMarginDiv(openXmlElement);
      model.TopMargin = GetTopMarginDiv(openXmlElement);
      model.BottomMargin = GetBottomMarginDiv(openXmlElement);
      model.DivBorder = GetDivBorder(openXmlElement);
      var divItems = openXmlElement.Elements<DXW.DivsChild>();
      if (divItems != null && divItems.Count() > 0)
      {
        model.Children = new DMW.DivsChildren { Parent = model };
        ElementCollectionConverter<DMW.Divs>.FillModelElementCollection(
          divItems, model.Children,
          GetDivsChild);
      }
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Div? openXmlElement, DMW.Div? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, model.Id, diffs, objName, propName))
        ok = false;
      if (!CmpBlockQuote(openXmlElement, model.IsBlockQuote, diffs, objName, propName))
        ok = false;
      if (!CmpBodyDiv(openXmlElement, model.IsBody, diffs, objName, propName))
        ok = false;
      if (!CmpLeftMarginDiv(openXmlElement, model.LeftMargin, diffs, objName, propName))
        ok = false;
      if (!CmpRightMarginDiv(openXmlElement, model.RightMargin, diffs, objName, propName))
        ok = false;
      if (!CmpTopMarginDiv(openXmlElement, model.TopMargin, diffs, objName, propName))
        ok = false;
      if (!CmpBottomMarginDiv(openXmlElement, model.BottomMargin, diffs, objName, propName))
        ok = false;
      if (!CmpDivBorder(openXmlElement, model.DivBorder, diffs, objName, propName))
        ok = false;
      var divItems = openXmlElement.Elements<DXW.DivsChild>();
      if (divItems != null && divItems.Count() > 0)
      {
        if (model.Children != null)
        {
          if (!ElementCollectionConverter<DMW.Divs>.CompareOpenXmlElementCollection(
            divItems, model.Children,
            CmpDivsChild, diffs, objName, propName))
            ok = false;
        }
        else
        {
          ok = false;
          diffs?.Add(objName, "Children.Count", divItems.Count(), 0);
        }
      }
      else
      {
        if (model.Children != null && model.Children.Count > 0)
        {
          ok = false;
          diffs?.Add(objName, "Children.Count", 0, model.Children.Count);
        }
      }
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXW.Div CreateOpenXmlElement(DMW.Div model)
  {
    var openXmlElement = new DXW.Div();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.Div openXmlElement, DMW.Div model)
  {
    SetId(openXmlElement, model.Id);
    SetBlockQuote(openXmlElement, model.IsBlockQuote);
    SetBodyDiv(openXmlElement, model.IsBody);
    SetLeftMarginDiv(openXmlElement, model.LeftMargin);
    SetRightMarginDiv(openXmlElement, model.RightMargin);
    SetTopMarginDiv(openXmlElement, model.TopMargin);
    SetBottomMarginDiv(openXmlElement, model.BottomMargin);
    SetDivBorder(openXmlElement, model.DivBorder);
    if (model.Children != null && model.Children.Count > 0)
    {
      var divItems = openXmlElement.Elements<DXW.DivsChild>();
      return ElementCollectionConverter<DMW.Divs>.UpdateOpenXmlElementCollection(
        openXmlElement,
        item => item is DXW.DivsChild,
        model.Children,
        CmpDivsChild,
        UpdateDivsChild,
        CreateDivsChild
      );
    }
    return true;
  }
  #endregion
}
