using DocumentFormat.OpenXml.Drawing.Charts;
using MultiLevelStringCache = DocumentModel.Drawings.Charts.MultiLevelStringCache;
using MultiLvlStrRefExtensionList = DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Multi Level String Reference.
/// </summary>
public static class MultiLevelStringReferenceConverter
{
  /// <summary>
  ///   Formula.
  /// </summary>
  public static String? GetFormula(MultiLevelStringReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Formula>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetFormula(MultiLevelStringReference? openXmlElement, String? value)
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
  ///   MultiLevelStringCache.
  /// </summary>
  public static MultiLevelStringCache? GetMultiLevelStringCache(MultiLevelStringReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache>();
    if (itemElement != null)
      return MultiLevelStringCacheConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMultiLevelStringCache(MultiLevelStringReference? openXmlElement, MultiLevelStringCache? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MultiLevelStringCacheConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   MultiLvlStrRefExtensionList.
  /// </summary>
  public static MultiLvlStrRefExtensionList? GetMultiLvlStrRefExtensionList(MultiLevelStringReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList>();
    if (itemElement != null)
      return MultiLvlStrRefExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMultiLvlStrRefExtensionList(MultiLevelStringReference? openXmlElement, MultiLvlStrRefExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MultiLvlStrRefExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.MultiLevelStringReference? CreateModelElement(MultiLevelStringReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.MultiLevelStringReference();
      value.Formula = GetFormula(openXmlElement);
      value.MultiLevelStringCache = GetMultiLevelStringCache(openXmlElement);
      value.MultiLvlStrRefExtensionList = GetMultiLvlStrRefExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.MultiLevelStringReference? value)
    where OpenXmlElementType : MultiLevelStringReference, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormula(openXmlElement, value?.Formula);
      SetMultiLevelStringCache(openXmlElement, value?.MultiLevelStringCache);
      SetMultiLvlStrRefExtensionList(openXmlElement, value?.MultiLvlStrRefExtensionList);
      return openXmlElement;
    }
    return default;
  }
}