using DocumentModel.Drawings.Diagrams;
using Constraints = DocumentFormat.OpenXml.Drawing.Diagrams.Constraints;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Constraint List.
/// </summary>
public static class ConstraintsConverter
{
  public static Collection<Constraint>? GetItems(Constraints? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Constraint>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Constraint>())
      {
        var newItem = ConstraintConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetItems(Constraints? openXmlElement, Collection<Constraint>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Constraint>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ConstraintConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Constraint>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Diagrams.Constraints? CreateModelElement(Constraints? openXmlElement)
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
    where OpenXmlElementType : Constraints, new()
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