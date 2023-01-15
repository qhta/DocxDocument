using DocumentFormat.OpenXml.Drawing.Charts;
using StringCache = DocumentModel.Drawings.Charts.StringCache;
using StrRefExtensionList = DocumentModel.Drawings.Charts.StrRefExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the StringReference Class.
/// </summary>
public static class StringReferenceConverter
{
  /// <summary>
  ///   Formula.
  /// </summary>
  public static String? GetFormula(StringReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Formula>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetFormula(StringReference? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Formula>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Formula { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   StringCache.
  /// </summary>
  public static StringCache? GetStringCache(StringReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringCache>();
    if (itemElement != null)
      return StringCacheConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStringCache(StringReference? openXmlElement, StringCache? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringCache>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StringCacheConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StringCache>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   StrRefExtensionList.
  /// </summary>
  public static StrRefExtensionList? GetStrRefExtensionList(StringReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList>();
    if (itemElement != null)
      return StrRefExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStrRefExtensionList(StringReference? openXmlElement, StrRefExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StrRefExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.StringReference? CreateModelElement(StringReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StringReference();
      value.Formula = GetFormula(openXmlElement);
      value.StringCache = GetStringCache(openXmlElement);
      value.StrRefExtensionList = GetStrRefExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.StringReference? value)
    where OpenXmlElementType : StringReference, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormula(openXmlElement, value?.Formula);
      SetStringCache(openXmlElement, value?.StringCache);
      SetStrRefExtensionList(openXmlElement, value?.StrRefExtensionList);
      return openXmlElement;
    }
    return default;
  }
}