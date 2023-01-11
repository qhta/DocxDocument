namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TemplateCommandGroup Class.
/// </summary>
public static class TemplateCommandGroupConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.KeyMapCustomizations>? GetKeyMapCustomizationses(DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.KeyMapCustomizations>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.KeyMapCustomizationsConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetKeyMapCustomizationses(DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.KeyMapCustomizations>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.KeyMapCustomizationsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.MismatchedKeyMapCustomization>? GetMismatchedKeyMapCustomizations(DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.MismatchedKeyMapCustomization>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.MismatchedKeyMapCustomizationConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetMismatchedKeyMapCustomizations(DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.MismatchedKeyMapCustomization>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.MismatchedKeyMapCustomizationConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Toolbars? GetToolbars(DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.Toolbars>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ToolbarsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetToolbars(DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup? openXmlElement, DocumentModel.Wordprocessing.Toolbars? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.Toolbars>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.ToolbarsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.Toolbars>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.AllocatedCommands>? GetAllocatedCommandses(DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.AllocatedCommands>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.AllocatedCommands>())
      {
        var newItem = DocumentModel.OpenXml.Wordprocessing.AllocatedCommandsConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetAllocatedCommandses(DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.AllocatedCommands>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.AllocatedCommands>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Wordprocessing.AllocatedCommandsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.AllocatedCommands>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.TemplateCommandGroup? CreateModelElement(DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
