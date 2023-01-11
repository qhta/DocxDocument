namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Diagram Relationship Table.
/// </summary>
public static class RelationTableConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public static DocumentModel.Vml.ExtensionHandlingBehaviorKind? GetExtension(DocumentFormat.OpenXml.Vml.Office.RelationTable? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  public static void SetExtension(DocumentFormat.OpenXml.Vml.Office.RelationTable? openXmlElement, DocumentModel.Vml.ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DocumentModel.Vml.ExtensionHandlingBehaviorKind>(value);
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Vml.Relation>? GetRelations(DocumentFormat.OpenXml.Vml.Office.RelationTable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Vml.Relation>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Vml.Office.Relation>())
      {
        var newItem = DocumentModel.OpenXml.Vml.RelationConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetRelations(DocumentFormat.OpenXml.Vml.Office.RelationTable? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Vml.Relation>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Office.Relation>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Vml.RelationConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Relation>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Vml.RelationTable? CreateModelElement(DocumentFormat.OpenXml.Vml.Office.RelationTable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.RelationTable();
      value.Extension = GetExtension(openXmlElement);
      value.Relations = GetRelations(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.RelationTable? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Office.RelationTable, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
