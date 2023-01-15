using DocumentFormat.OpenXml.Drawing.Charts;
using NumberingCache = DocumentModel.Drawings.Charts.NumberingCache;
using NumRefExtensionList = DocumentModel.Drawings.Charts.NumRefExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Number Reference.
/// </summary>
public static class NumberReferenceConverter
{
  /// <summary>
  ///   Formula.
  /// </summary>
  public static String? GetFormula(NumberReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Formula>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetFormula(NumberReference? openXmlElement, String? value)
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
  ///   NumberingCache.
  /// </summary>
  public static NumberingCache? GetNumberingCache(NumberReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingCache>();
    if (itemElement != null)
      return NumberingCacheConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingCache(NumberReference? openXmlElement, NumberingCache? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingCache>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingCacheConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumberingCache>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   NumRefExtensionList.
  /// </summary>
  public static NumRefExtensionList? GetNumRefExtensionList(NumberReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList>();
    if (itemElement != null)
      return NumRefExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumRefExtensionList(NumberReference? openXmlElement, NumRefExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumRefExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.NumberReference? CreateModelElement(NumberReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.NumberReference();
      value.Formula = GetFormula(openXmlElement);
      value.NumberingCache = GetNumberingCache(openXmlElement);
      value.NumRefExtensionList = GetNumRefExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.NumberReference? value)
    where OpenXmlElementType : NumberReference, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormula(openXmlElement, value?.Formula);
      SetNumberingCache(openXmlElement, value?.NumberingCache);
      SetNumRefExtensionList(openXmlElement, value?.NumRefExtensionList);
      return openXmlElement;
    }
    return default;
  }
}