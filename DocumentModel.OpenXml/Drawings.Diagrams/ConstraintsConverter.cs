namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Constraint List.
/// </summary>
public static class ConstraintsConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Constraint>? GetItems(DocumentFormat.OpenXml.Drawing.Diagrams.Constraints? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Constraint>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Constraint>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Diagrams.ConstraintConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetItems(DocumentFormat.OpenXml.Drawing.Diagrams.Constraints? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Constraint>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Constraint>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Diagrams.ConstraintConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Constraint>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Constraints? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.Constraints? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Constraints();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Constraints? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.Constraints, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
