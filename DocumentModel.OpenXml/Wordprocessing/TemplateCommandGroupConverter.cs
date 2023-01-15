using DocumentModel.Wordprocessing;
using TemplateCommandGroup = DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the TemplateCommandGroup Class.
/// </summary>
public static class TemplateCommandGroupConverter
{
  public static Collection<KeyMapCustomizations>? GetKeyMapCustomizationses(TemplateCommandGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<KeyMapCustomizations>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations>())
      {
        var newItem = KeyMapCustomizationsConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetKeyMapCustomizationses(TemplateCommandGroup? openXmlElement, Collection<KeyMapCustomizations>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = KeyMapCustomizationsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static Collection<MismatchedKeyMapCustomization>? GetMismatchedKeyMapCustomizations(TemplateCommandGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<MismatchedKeyMapCustomization>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization>())
      {
        var newItem = MismatchedKeyMapCustomizationConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetMismatchedKeyMapCustomizations(TemplateCommandGroup? openXmlElement, Collection<MismatchedKeyMapCustomization>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = MismatchedKeyMapCustomizationConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static Toolbars? GetToolbars(TemplateCommandGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.Toolbars>();
    if (itemElement != null)
      return ToolbarsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetToolbars(TemplateCommandGroup? openXmlElement, Toolbars? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.Toolbars>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ToolbarsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.Toolbars>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<AllocatedCommands>? GetAllocatedCommandses(TemplateCommandGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<AllocatedCommands>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.AllocatedCommands>())
      {
        var newItem = AllocatedCommandsConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetAllocatedCommandses(TemplateCommandGroup? openXmlElement, Collection<AllocatedCommands>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.AllocatedCommands>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = AllocatedCommandsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.AllocatedCommands>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Wordprocessing.TemplateCommandGroup? CreateModelElement(TemplateCommandGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TemplateCommandGroup();
      value.KeyMapCustomizationses = GetKeyMapCustomizationses(openXmlElement);
      value.MismatchedKeyMapCustomizations = GetMismatchedKeyMapCustomizations(openXmlElement);
      value.Toolbars = GetToolbars(openXmlElement);
      value.AllocatedCommandses = GetAllocatedCommandses(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TemplateCommandGroup? value)
    where OpenXmlElementType : TemplateCommandGroup, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetKeyMapCustomizationses(openXmlElement, value?.KeyMapCustomizationses);
      SetMismatchedKeyMapCustomizations(openXmlElement, value?.MismatchedKeyMapCustomizations);
      SetToolbars(openXmlElement, value?.Toolbars);
      SetAllocatedCommandses(openXmlElement, value?.AllocatedCommandses);
      return openXmlElement;
    }
    return default;
  }
}