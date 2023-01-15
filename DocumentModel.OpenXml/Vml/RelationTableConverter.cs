using DocumentFormat.OpenXml.Vml;
using DocumentModel.Vml;
using RelationTable = DocumentFormat.OpenXml.Vml.Office.RelationTable;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Diagram Relationship Table.
/// </summary>
public static class RelationTableConverter
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public static ExtensionHandlingBehaviorKind? GetExtension(RelationTable? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }

  public static void SetExtension(RelationTable? openXmlElement, ExtensionHandlingBehaviorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Extension = EnumValueConverter.CreateEnumValue<ExtensionHandlingBehaviorValues, ExtensionHandlingBehaviorKind>(value);
  }

  public static Collection<Relation>? GetRelations(RelationTable? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Relation>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Vml.Office.Relation>())
      {
        var newItem = RelationConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetRelations(RelationTable? openXmlElement, Collection<Relation>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Office.Relation>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = RelationConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.Relation>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Vml.RelationTable? CreateModelElement(RelationTable? openXmlElement)
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
    where OpenXmlElementType : RelationTable, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetRelations(openXmlElement, value?.Relations);
      return openXmlElement;
    }
    return default;
  }
}