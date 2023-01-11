namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List of Shape Adjust Values.
/// </summary>
public static class AdjustValueListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ShapeGuide>? GetShapeGuides(DocumentFormat.OpenXml.Drawing.AdjustValueList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ShapeGuide>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ShapeGuide>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.ShapeGuideConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetShapeGuides(DocumentFormat.OpenXml.Drawing.AdjustValueList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ShapeGuide>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ShapeGuide>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.ShapeGuideConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ShapeGuide>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.AdjustValueList? CreateModelElement(DocumentFormat.OpenXml.Drawing.AdjustValueList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AdjustValueList();
      value.ShapeGuides = GetShapeGuides(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AdjustValueList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.AdjustValueList, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
