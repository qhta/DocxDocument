namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the StringDimension Class.
/// </summary>
public static class StringDimensionConverter
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.StringDimensionType? GetType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType, DocumentModel.Drawings.ChartDrawings.StringDimensionType>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement, DocumentModel.Drawings.ChartDrawings.StringDimensionType? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType, DocumentModel.Drawings.ChartDrawings.StringDimensionType>(value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? GetFormula(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Formula>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.OpenXmlFormulaElementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFormula(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement, DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? GetNfFormula(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NfFormula>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.OpenXmlFormulaElementConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNfFormula(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement, DocumentModel.Drawings.ChartDrawings.OpenXmlFormulaElement? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.StringLevel>? GetStringLevels(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.StringLevel>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.StringLevelConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetStringLevels(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.StringLevel>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.StringLevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.StringLevel? GetStringLevel(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.StringLevelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStringLevel(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement, DocumentModel.Drawings.ChartDrawings.StringLevel? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.StringLevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.StringDimension? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension, new()
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
