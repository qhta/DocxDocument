using DocumentFormat.OpenXml.Drawing.Charts;
using Formatting = DocumentFormat.OpenXml.Drawing.Charts.Formatting;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the Protection Class.
/// </summary>
public static class ProtectionConverter
{
  /// <summary>
  ///   Chart Object.
  /// </summary>
  public static Boolean? GetChartObject(Protection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ChartObject>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetChartObject(Protection? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ChartObject>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ChartObject();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Data Cannot Be Changed.
  /// </summary>
  public static Boolean? GetData(Protection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Data>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetData(Protection? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Data>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Data();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Formatting.
  /// </summary>
  public static Boolean? GetFormatting(Protection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Formatting>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetFormatting(Protection? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Formatting>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Formatting();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Selection.
  /// </summary>
  public static Boolean? GetSelection(Protection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Selection>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSelection(Protection? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Selection>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Selection();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   User Interface.
  /// </summary>
  public static Boolean? GetUserInterface(Protection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UserInterface>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetUserInterface(Protection? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<UserInterface>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new UserInterface();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.Protection? CreateModelElement(Protection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Protection();
      value.ChartObject = GetChartObject(openXmlElement);
      value.Data = GetData(openXmlElement);
      value.Formatting = GetFormatting(openXmlElement);
      value.Selection = GetSelection(openXmlElement);
      value.UserInterface = GetUserInterface(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Protection? value)
    where OpenXmlElementType : Protection, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartObject(openXmlElement, value?.ChartObject);
      SetData(openXmlElement, value?.Data);
      SetFormatting(openXmlElement, value?.Formatting);
      SetSelection(openXmlElement, value?.Selection);
      SetUserInterface(openXmlElement, value?.UserInterface);
      return openXmlElement;
    }
    return default;
  }
}