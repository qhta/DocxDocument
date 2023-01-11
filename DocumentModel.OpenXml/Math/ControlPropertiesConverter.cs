namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Control Properties.
/// </summary>
public static class ControlPropertiesConverter
{
  public static DocumentModel.Wordprocessing.RunProperties? GetRunProperties(DocumentFormat.OpenXml.Math.ControlProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRunProperties(DocumentFormat.OpenXml.Math.ControlProperties? openXmlElement, DocumentModel.Wordprocessing.RunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.RunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.InsertedMathControl? GetInsertedMathControl(DocumentFormat.OpenXml.Math.ControlProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.InsertedMathControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetInsertedMathControl(DocumentFormat.OpenXml.Math.ControlProperties? openXmlElement, DocumentModel.Wordprocessing.InsertedMathControl? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.InsertedMathControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.DeletedMathControl? GetDeletedMathControl(DocumentFormat.OpenXml.Math.ControlProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DeletedMathControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDeletedMathControl(DocumentFormat.OpenXml.Math.ControlProperties? openXmlElement, DocumentModel.Wordprocessing.DeletedMathControl? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.DeletedMathControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MoveFromMathControl? GetMoveFromMathControl(DocumentFormat.OpenXml.Math.ControlProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveFromMathControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveFromMathControl(DocumentFormat.OpenXml.Math.ControlProperties? openXmlElement, DocumentModel.Wordprocessing.MoveFromMathControl? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.MoveFromMathControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.MoveToMathControl? GetMoveToMathControl(DocumentFormat.OpenXml.Math.ControlProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MoveToMathControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMoveToMathControl(DocumentFormat.OpenXml.Math.ControlProperties? openXmlElement, DocumentModel.Wordprocessing.MoveToMathControl? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.MoveToMathControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.ControlProperties? CreateModelElement(DocumentFormat.OpenXml.Math.ControlProperties? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.ControlProperties, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
