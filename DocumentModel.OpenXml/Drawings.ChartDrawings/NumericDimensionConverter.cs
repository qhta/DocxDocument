namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumericDimension Class.
/// </summary>
public static class NumericDimensionConverter
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.NumericDimensionType? GetType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType, DocumentModel.Drawings.ChartDrawings.NumericDimensionType>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension openXmlElement, DocumentModel.Drawings.ChartDrawings.NumericDimensionType? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType, DocumentModel.Drawings.ChartDrawings.NumericDimensionType>(value);
  }
  
  private static DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? GetFormula(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.OpenXmlFormulaElementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFormula(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension openXmlElement, DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.OpenXmlFormulaElementConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? GetNfFormula(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NfFormula>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.OpenXmlFormulaElementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNfFormula(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension openXmlElement, DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NfFormula>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.OpenXmlFormulaElementConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NfFormula>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.NumericLevel> GetNumericLevels(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.NumericLevel>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.NumericLevelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetNumericLevels(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.NumericLevel>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.NumericLevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DocumentModel.Drawings.ChartDrawings.NumericLevel? GetNumericLevel(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.NumericLevelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumericLevel(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension openXmlElement, DocumentModel.Drawings.ChartDrawings.NumericLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.NumericLevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.NumericDimension? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension, new()
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
