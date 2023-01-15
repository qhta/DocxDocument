using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using OpenXmlFormulaElement = DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement;
using StringDimension = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension;
using StringDimensionType = DocumentModel.Drawings.ChartDrawings.StringDimensionType;
using StringLevel = DocumentModel.Drawings.ChartDrawings.StringLevel;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the StringDimension Class.
/// </summary>
public static class StringDimensionConverter
{
  /// <summary>
  ///   type, this property is only available in Office 2016 and later.
  /// </summary>
  public static StringDimensionType? GetType(StringDimension? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType, StringDimensionType>(openXmlElement?.Type?.Value);
  }

  public static void SetType(StringDimension? openXmlElement, StringDimensionType? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType, StringDimensionType>(value);
  }

  public static OpenXmlFormulaElement? GetFormula(StringDimension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Formula>();
    if (itemElement != null)
      return OpenXmlFormulaElementConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFormula(StringDimension? openXmlElement, OpenXmlFormulaElement? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Formula>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OpenXmlFormulaElementConverter.CreateOpenXmlElement<Formula>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static OpenXmlFormulaElement? GetNfFormula(StringDimension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NfFormula>();
    if (itemElement != null)
      return OpenXmlFormulaElementConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNfFormula(StringDimension? openXmlElement, OpenXmlFormulaElement? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NfFormula>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OpenXmlFormulaElementConverter.CreateOpenXmlElement<NfFormula>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<StringLevel>? GetStringLevels(StringDimension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<StringLevel>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>())
      {
        var newItem = StringLevelConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetStringLevels(StringDimension? openXmlElement, Collection<StringLevel>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = StringLevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static StringLevel? GetStringLevel(StringDimension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>();
    if (itemElement != null)
      return StringLevelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStringLevel(StringDimension? openXmlElement, StringLevel? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StringLevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.StringDimension? CreateModelElement(StringDimension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.StringDimension();
      value.Type = GetType(openXmlElement);
      value.Formula = GetFormula(openXmlElement);
      value.NfFormula = GetNfFormula(openXmlElement);
      value.StringLevels = GetStringLevels(openXmlElement);
      value.StringLevel = GetStringLevel(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.StringDimension? value)
    where OpenXmlElementType : StringDimension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetFormula(openXmlElement, value?.Formula);
      SetNfFormula(openXmlElement, value?.NfFormula);
      SetStringLevels(openXmlElement, value?.StringLevels);
      SetStringLevel(openXmlElement, value?.StringLevel);
      return openXmlElement;
    }
    return default;
  }
}