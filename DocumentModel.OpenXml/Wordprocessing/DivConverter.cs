namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Information About Single HTML div Element.
/// </summary>
public static class DivConverter
{
  /// <summary>
  /// div Data ID
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Data for HTML blockquote Element.
  /// </summary>
  private static Boolean? GetBlockQuote(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BlockQuote>();
    return itemElement != null;
  }
  
  private static void SetBlockQuote(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BlockQuote>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.BlockQuote();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Data for HTML body Element.
  /// </summary>
  private static Boolean? GetBodyDiv(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BodyDiv>();
    return itemElement != null;
  }
  
  private static void SetBodyDiv(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BodyDiv>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.BodyDiv();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Left Margin for HTML div.
  /// </summary>
  private static String? GetLeftMarginDiv(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LeftMarginDiv>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLeftMarginDiv(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LeftMarginDiv>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.LeftMarginDiv { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Right Margin for HTML div.
  /// </summary>
  private static String? GetRightMarginDiv(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RightMarginDiv>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetRightMarginDiv(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RightMarginDiv>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.RightMarginDiv { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Top Margin for HTML div.
  /// </summary>
  private static String? GetTopMarginDiv(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TopMarginDiv>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetTopMarginDiv(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TopMarginDiv>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.TopMarginDiv { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Bottom Margin for HTML div.
  /// </summary>
  private static String? GetBottomMarginDiv(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BottomMarginDiv>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetBottomMarginDiv(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.BottomMarginDiv>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.BottomMarginDiv { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Set of Borders for HTML div.
  /// </summary>
  private static DocumentModel.Wordprocessing.DivBorder? GetDivBorder(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DivBorder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DivBorderConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDivBorder(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement, DocumentModel.Wordprocessing.DivBorder? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DivBorder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.DivBorderConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DivBorder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.DivsChild> GetDivsChilds(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.DivsChild>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.DivsChild>())
    {
      var newItem = DocumentModel.OpenXml.Wordprocessing.DivsChildConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetDivsChilds(DocumentFormat.OpenXml.Wordprocessing.Div openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.DivsChild>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.DivsChild>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.DivsChildConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DivsChild>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Div? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Div? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Div();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Div? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Div, new()
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
