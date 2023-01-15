using DocumentModel.Wordprocessing;
using Toolbars = DocumentFormat.OpenXml.Office.Word.Toolbars;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the Toolbars Class.
/// </summary>
public static class ToolbarsConverter
{
  public static Collection<AllocatedCommandManifest>? GetAllocatedCommandManifests(Toolbars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<AllocatedCommandManifest>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest>())
      {
        var newItem = AllocatedCommandManifestConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetAllocatedCommandManifests(Toolbars? openXmlElement, Collection<AllocatedCommandManifest>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = AllocatedCommandManifestConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static Collection<ToolbarData>? GetToolbarDatas(Toolbars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ToolbarData>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.ToolbarData>())
      {
        var newItem = ToolbarDataConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetToolbarDatas(Toolbars? openXmlElement, Collection<ToolbarData>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.ToolbarData>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ToolbarDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.ToolbarData>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.Toolbars? CreateModelElement(Toolbars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Toolbars();
      value.AllocatedCommandManifests = GetAllocatedCommandManifests(openXmlElement);
      value.ToolbarDatas = GetToolbarDatas(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Toolbars? value)
    where OpenXmlElementType : Toolbars, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAllocatedCommandManifests(openXmlElement, value?.AllocatedCommandManifests);
      SetToolbarDatas(openXmlElement, value?.ToolbarDatas);
      return openXmlElement;
    }
    return default;
  }
}