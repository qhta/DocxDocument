using DocumentFormat.OpenXml.Math;
using DocumentModel.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using RunProperties = DocumentModel.Wordprocessing.RunProperties;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Control Properties.
/// </summary>
public static class ControlPropertiesConverter
{
  public static RunProperties? GetRunProperties(ControlProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
    if (itemElement != null)
      return Wordprocessing.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunProperties(ControlProperties? openXmlElement, RunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Wordprocessing.RunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static InsertedMathControl? GetInsertedMathControl(ControlProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl>();
    if (itemElement != null)
      return InsertedMathControlConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetInsertedMathControl(ControlProperties? openXmlElement, InsertedMathControl? value)
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

  public static DeletedMathControl? GetDeletedMathControl(ControlProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl>();
    if (itemElement != null)
      return DeletedMathControlConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDeletedMathControl(ControlProperties? openXmlElement, DeletedMathControl? value)
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

  public static MoveFromMathControl? GetMoveFromMathControl(ControlProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl>();
    if (itemElement != null)
      return MoveFromMathControlConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveFromMathControl(ControlProperties? openXmlElement, MoveFromMathControl? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MoveFromMathControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MoveToMathControl? GetMoveToMathControl(ControlProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl>();
    if (itemElement != null)
      return MoveToMathControlConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMoveToMathControl(ControlProperties? openXmlElement, MoveToMathControl? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MoveToMathControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.ControlProperties? CreateModelElement(ControlProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.ControlProperties();
      value.RunProperties = GetRunProperties(openXmlElement);
      value.InsertedMathControl = GetInsertedMathControl(openXmlElement);
      value.DeletedMathControl = GetDeletedMathControl(openXmlElement);
      value.MoveFromMathControl = GetMoveFromMathControl(openXmlElement);
      value.MoveToMathControl = GetMoveToMathControl(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.ControlProperties? value)
    where OpenXmlElementType : ControlProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunProperties(openXmlElement, value?.RunProperties);
      SetInsertedMathControl(openXmlElement, value?.InsertedMathControl);
      SetDeletedMathControl(openXmlElement, value?.DeletedMathControl);
      SetMoveFromMathControl(openXmlElement, value?.MoveFromMathControl);
      SetMoveToMathControl(openXmlElement, value?.MoveToMathControl);
      return openXmlElement;
    }
    return default;
  }
}