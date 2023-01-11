namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Major Font.
/// </summary>
public static class MajorFontConverter
{
  public static DocumentModel.Drawings.TextFontType? GetLatinFont(DocumentFormat.OpenXml.Drawing.MajorFont? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LatinFont>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLatinFont(DocumentFormat.OpenXml.Drawing.MajorFont? openXmlElement, DocumentModel.Drawings.TextFontType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LatinFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LatinFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.TextFontType? GetEastAsianFont(DocumentFormat.OpenXml.Drawing.MajorFont? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EastAsianFont>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEastAsianFont(DocumentFormat.OpenXml.Drawing.MajorFont? openXmlElement, DocumentModel.Drawings.TextFontType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EastAsianFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EastAsianFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.TextFontType? GetComplexScriptFont(DocumentFormat.OpenXml.Drawing.MajorFont? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ComplexScriptFont>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetComplexScriptFont(DocumentFormat.OpenXml.Drawing.MajorFont? openXmlElement, DocumentModel.Drawings.TextFontType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ComplexScriptFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.TextFontTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ComplexScriptFont>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.SupplementalFont>? GetSupplementalFonts(DocumentFormat.OpenXml.Drawing.MajorFont? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.SupplementalFont>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.SupplementalFont>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.SupplementalFontConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetSupplementalFonts(DocumentFormat.OpenXml.Drawing.MajorFont? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.SupplementalFont>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.SupplementalFont>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.SupplementalFontConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SupplementalFont>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.MajorFont? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.MajorFont? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.MajorFont? CreateModelElement(DocumentFormat.OpenXml.Drawing.MajorFont? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.MajorFont();
      value.LatinFont = GetLatinFont(openXmlElement);
      value.EastAsianFont = GetEastAsianFont(openXmlElement);
      value.ComplexScriptFont = GetComplexScriptFont(openXmlElement);
      value.SupplementalFonts = GetSupplementalFonts(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.MajorFont? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.MajorFont, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
