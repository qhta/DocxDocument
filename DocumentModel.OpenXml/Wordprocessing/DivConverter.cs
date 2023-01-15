using DocumentFormat.OpenXml.Wordprocessing;
using DivBorder = DocumentModel.Wordprocessing.DivBorder;
using DivsChild = DocumentModel.Wordprocessing.DivsChild;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Information About Single HTML div Element.
/// </summary>
public static class DivConverter
{
  /// <summary>
  ///   div Data ID
  /// </summary>
  public static String? GetId(Div? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(Div? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Data for HTML blockquote Element.
  /// </summary>
  public static Boolean? GetBlockQuote(Div? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BlockQuote>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBlockQuote(Div? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<BlockQuote>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new BlockQuote();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Data for HTML body Element.
  /// </summary>
  public static Boolean? GetBodyDiv(Div? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BodyDiv>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBodyDiv(Div? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<BodyDiv>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new BodyDiv();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Left Margin for HTML div.
  /// </summary>
  public static String? GetLeftMarginDiv(Div? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LeftMarginDiv>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLeftMarginDiv(Div? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LeftMarginDiv>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new LeftMarginDiv { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Right Margin for HTML div.
  /// </summary>
  public static String? GetRightMarginDiv(Div? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<RightMarginDiv>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetRightMarginDiv(Div? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RightMarginDiv>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new RightMarginDiv { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Top Margin for HTML div.
  /// </summary>
  public static String? GetTopMarginDiv(Div? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TopMarginDiv>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetTopMarginDiv(Div? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TopMarginDiv>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new TopMarginDiv { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Bottom Margin for HTML div.
  /// </summary>
  public static String? GetBottomMarginDiv(Div? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<BottomMarginDiv>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetBottomMarginDiv(Div? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BottomMarginDiv>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new BottomMarginDiv { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Set of Borders for HTML div.
  /// </summary>
  public static DivBorder? GetDivBorder(Div? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DivBorder>();
    if (itemElement != null)
      return DivBorderConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDivBorder(Div? openXmlElement, DivBorder? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DivBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DivBorderConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DivBorder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<DivsChild>? GetDivsChilds(Div? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DivsChild>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.DivsChild>())
      {
        var newItem = DivsChildConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetDivsChilds(Div? openXmlElement, Collection<DivsChild>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.DivsChild>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = DivsChildConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DivsChild>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.Div? CreateModelElement(Div? openXmlElement)
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
    where OpenXmlElementType : Div, new()
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