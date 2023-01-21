namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Information About Single HTML div Element.
/// </summary>
public static class DivConverter
{
  /// <summary>
  /// div Data ID
  /// </summary>
  private static String? GetId(DXW.Div openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXW.Div openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Data for HTML blockquote Element.
  /// </summary>
  private static Boolean? GetBlockQuote(DXW.Div openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BlockQuote>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetBlockQuote(DXW.Div openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.BlockQuote>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.BlockQuote();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Data for HTML body Element.
  /// </summary>
  private static Boolean? GetBodyDiv(DXW.Div openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BodyDiv>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetBodyDiv(DXW.Div openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.BodyDiv>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.BodyDiv();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Left Margin for HTML div.
  /// </summary>
  private static String? GetLeftMarginDiv(DXW.Div openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.LeftMarginDiv>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLeftMarginDiv(DXW.Div openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.LeftMarginDiv>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.LeftMarginDiv { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Right Margin for HTML div.
  /// </summary>
  private static String? GetRightMarginDiv(DXW.Div openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.RightMarginDiv>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetRightMarginDiv(DXW.Div openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RightMarginDiv>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.RightMarginDiv { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Top Margin for HTML div.
  /// </summary>
  private static String? GetTopMarginDiv(DXW.Div openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TopMarginDiv>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetTopMarginDiv(DXW.Div openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TopMarginDiv>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.TopMarginDiv { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Bottom Margin for HTML div.
  /// </summary>
  private static String? GetBottomMarginDiv(DXW.Div openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.BottomMarginDiv>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetBottomMarginDiv(DXW.Div openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.BottomMarginDiv>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.BottomMarginDiv { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Set of Borders for HTML div.
  /// </summary>
  private static DMW.DivBorder? GetDivBorder(DXW.Div openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.DivBorder>();
    if (itemElement != null)
      return DMXW.DivBorderConverter.CreateModelElement(itemElement);
    return null;
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
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMW.DivsChild> GetDivsChilds(DXW.Div openXmlElement)
  {
    var collection = new Collection<DMW.DivsChild>();
    foreach (var item in openXmlElement.Elements<DXW.DivsChild>())
    {
      var newItem = DMXW.DivsChildConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetDivsChilds(DXW.Div openXmlElement, Collection<DMW.DivsChild>? value)
  {
    openXmlElement.RemoveAllChildren<DXW.DivsChild>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.DivsChildConverter.CreateOpenXmlElement<DXW.DivsChild>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.Div? CreateModelElement(DXW.Div? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Div();
      value.Id = GetId(openXmlElement);
      value.BlockQuote = GetBlockQuote(openXmlElement);
      value.BodyDiv = GetBodyDiv(openXmlElement);
      value.LeftMarginDiv = GetLeftMarginDiv(openXmlElement);
      value.RightMarginDiv = GetRightMarginDiv(openXmlElement);
      value.TopMarginDiv = GetTopMarginDiv(openXmlElement);
      value.BottomMarginDiv = GetBottomMarginDiv(openXmlElement);
      value.DivBorder = GetDivBorder(openXmlElement);
      value.DivsChilds = GetDivsChilds(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Div? value)
    where OpenXmlElementType: DXW.Div, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetBlockQuote(openXmlElement, value?.BlockQuote);
      SetBodyDiv(openXmlElement, value?.BodyDiv);
      SetLeftMarginDiv(openXmlElement, value?.LeftMarginDiv);
      SetRightMarginDiv(openXmlElement, value?.RightMarginDiv);
      SetTopMarginDiv(openXmlElement, value?.TopMarginDiv);
      SetBottomMarginDiv(openXmlElement, value?.BottomMarginDiv);
      SetDivBorder(openXmlElement, value?.DivBorder);
      SetDivsChilds(openXmlElement, value?.DivsChilds);
      return openXmlElement;
    }
    return default;
  }
}
