using DocumentModel.Drawings.Charts;
using StrRefExtension = DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the StrRefExtension Class.
/// </summary>
public static class StrRefExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(StrRefExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(StrRefExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static FullReference? GetFullReference(StrRefExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference>();
    if (itemElement != null)
      return FullReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFullReference(StrRefExtension? openXmlElement, FullReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FullReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FullReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LevelReference? GetLevelReference(StrRefExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference>();
    if (itemElement != null)
      return LevelReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLevelReference(StrRefExtension? openXmlElement, LevelReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LevelReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.LevelReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static FormulaReference? GetFormulaReference(StrRefExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference>();
    if (itemElement != null)
      return FormulaReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFormulaReference(StrRefExtension? openXmlElement, FormulaReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormulaReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FormulaReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.StrRefExtension? CreateModelElement(StrRefExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StrRefExtension();
      value.Uri = GetUri(openXmlElement);
      value.FullReference = GetFullReference(openXmlElement);
      value.LevelReference = GetLevelReference(openXmlElement);
      value.FormulaReference = GetFormulaReference(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.StrRefExtension? value)
    where OpenXmlElementType : StrRefExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFullReference(openXmlElement, value?.FullReference);
      SetLevelReference(openXmlElement, value?.LevelReference);
      SetFormulaReference(openXmlElement, value?.FormulaReference);
      return openXmlElement;
    }
    return default;
  }
}