using DocumentModel.Wordprocessing;
using MoveToMathControl = DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the MoveToMathControl Class.
/// </summary>
public static class MoveToMathControlConverter
{
  public static RunProperties? GetRunProperties(MoveToMathControl? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
    if (itemElement != null)
      return RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunProperties(MoveToMathControl? openXmlElement, RunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static InsertedMathControl? GetInsertedMathControl(MoveToMathControl? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl>();
    if (itemElement != null)
      return InsertedMathControlConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetInsertedMathControl(MoveToMathControl? openXmlElement, InsertedMathControl? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = InsertedMathControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DeletedMathControl? GetDeletedMathControl(MoveToMathControl? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl>();
    if (itemElement != null)
      return DeletedMathControlConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDeletedMathControl(MoveToMathControl? openXmlElement, DeletedMathControl? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DeletedMathControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.MoveToMathControl? CreateModelElement(MoveToMathControl? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.MoveToMathControl();
      value.RunProperties = GetRunProperties(openXmlElement);
      value.InsertedMathControl = GetInsertedMathControl(openXmlElement);
      value.DeletedMathControl = GetDeletedMathControl(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.MoveToMathControl? value)
    where OpenXmlElementType : MoveToMathControl, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunProperties(openXmlElement, value?.RunProperties);
      SetInsertedMathControl(openXmlElement, value?.InsertedMathControl);
      SetDeletedMathControl(openXmlElement, value?.DeletedMathControl);
      return openXmlElement;
    }
    return default;
  }
}