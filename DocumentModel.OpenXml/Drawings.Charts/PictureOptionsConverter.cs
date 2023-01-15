using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using PictureOptions = DocumentFormat.OpenXml.Drawing.Charts.PictureOptions;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the PictureOptions Class.
/// </summary>
public static class PictureOptionsConverter
{
  /// <summary>
  ///   Apply To Front.
  /// </summary>
  public static Boolean? GetApplyToFront(PictureOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ApplyToFront>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetApplyToFront(PictureOptions? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ApplyToFront>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ApplyToFront();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Apply To Sides.
  /// </summary>
  public static Boolean? GetApplyToSides(PictureOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ApplyToSides>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetApplyToSides(PictureOptions? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ApplyToSides>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ApplyToSides();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Apply to End.
  /// </summary>
  public static Boolean? GetApplyToEnd(PictureOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ApplyToEnd>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetApplyToEnd(PictureOptions? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ApplyToEnd>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ApplyToEnd();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Picture Format.
  /// </summary>
  public static PictureFormatKind? GetPictureFormat(PictureOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PictureFormat>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<PictureFormatValues, PictureFormatKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetPictureFormat(PictureOptions? openXmlElement, PictureFormatKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PictureFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<PictureFormat, PictureFormatValues, PictureFormatKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Picture Stack Unit.
  /// </summary>
  public static Double? GetPictureStackUnit(PictureOptions? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PictureStackUnit>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPictureStackUnit(PictureOptions? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PictureStackUnit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PictureStackUnit { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.PictureOptions? CreateModelElement(PictureOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PictureOptions();
      value.ApplyToFront = GetApplyToFront(openXmlElement);
      value.ApplyToSides = GetApplyToSides(openXmlElement);
      value.ApplyToEnd = GetApplyToEnd(openXmlElement);
      value.PictureFormat = GetPictureFormat(openXmlElement);
      value.PictureStackUnit = GetPictureStackUnit(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.PictureOptions? value)
    where OpenXmlElementType : PictureOptions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetApplyToFront(openXmlElement, value?.ApplyToFront);
      SetApplyToSides(openXmlElement, value?.ApplyToSides);
      SetApplyToEnd(openXmlElement, value?.ApplyToEnd);
      SetPictureFormat(openXmlElement, value?.PictureFormat);
      SetPictureStackUnit(openXmlElement, value?.PictureStackUnit);
      return openXmlElement;
    }
    return default;
  }
}