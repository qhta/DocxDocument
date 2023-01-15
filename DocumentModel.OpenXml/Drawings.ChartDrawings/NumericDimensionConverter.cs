using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using NumericDimension = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension;
using NumericDimensionType = DocumentModel.Drawings.ChartDrawings.NumericDimensionType;
using NumericLevel = DocumentModel.Drawings.ChartDrawings.NumericLevel;
using OpenXmlFormulaElement = DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the NumericDimension Class.
/// </summary>
public static class NumericDimensionConverter
{
  /// <summary>
  ///   type, this property is only available in Office 2016 and later.
  /// </summary>
  public static NumericDimensionType? GetType(NumericDimension? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType, NumericDimensionType>(openXmlElement?.Type?.Value);
  }

  public static void SetType(NumericDimension? openXmlElement, NumericDimensionType? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType, NumericDimensionType>(value);
  }

  public static OpenXmlFormulaElement? GetFormula(NumericDimension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Formula>();
    if (itemElement != null)
      return OpenXmlFormulaElementConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFormula(NumericDimension? openXmlElement, OpenXmlFormulaElement? value)
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

  public static OpenXmlFormulaElement? GetNfFormula(NumericDimension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<NfFormula>();
    if (itemElement != null)
      return OpenXmlFormulaElementConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNfFormula(NumericDimension? openXmlElement, OpenXmlFormulaElement? value)
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

  public static Collection<NumericLevel>? GetNumericLevels(NumericDimension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<NumericLevel>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>())
      {
        var newItem = NumericLevelConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetNumericLevels(NumericDimension? openXmlElement, Collection<NumericLevel>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = NumericLevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static NumericLevel? GetNumericLevel(NumericDimension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>();
    if (itemElement != null)
      return NumericLevelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumericLevel(NumericDimension? openXmlElement, NumericLevel? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumericLevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.NumericDimension? CreateModelElement(NumericDimension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.NumericDimension();
      value.Type = GetType(openXmlElement);
      value.Formula = GetFormula(openXmlElement);
      value.NfFormula = GetNfFormula(openXmlElement);
      value.NumericLevels = GetNumericLevels(openXmlElement);
      value.NumericLevel = GetNumericLevel(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.NumericDimension? value)
    where OpenXmlElementType : NumericDimension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetFormula(openXmlElement, value?.Formula);
      SetNfFormula(openXmlElement, value?.NfFormula);
      SetNumericLevels(openXmlElement, value?.NumericLevels);
      SetNumericLevel(openXmlElement, value?.NumericLevel);
      return openXmlElement;
    }
    return default;
  }
}