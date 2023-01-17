namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Data Model.
/// </summary>
public static class DataModelConverter
{
  /// <summary>
  /// Point List.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.PointList? GetPointList(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PointList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.PointListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPointList(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel openXmlElement, DocumentModel.Drawings.Diagrams.PointList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PointList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagrams.PointListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.PointList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Connection List.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.ConnectionList? GetConnectionList(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ConnectionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetConnectionList(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel openXmlElement, DocumentModel.Drawings.Diagrams.ConnectionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ConnectionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Background Formatting.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.Background? GetBackground(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Background>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.BackgroundConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackground(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel openXmlElement, DocumentModel.Drawings.Diagrams.Background? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Background>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagrams.BackgroundConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Background>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Whole E2O Formatting.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.Whole? GetWhole(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Whole>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.WholeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetWhole(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel openXmlElement, DocumentModel.Drawings.Diagrams.Whole? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Whole>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagrams.WholeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Whole>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataModelExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.DataModelExtensionList? GetDataModelExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.DataModelExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataModelExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel openXmlElement, DocumentModel.Drawings.Diagrams.DataModelExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagrams.DataModelExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.DataModel? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.DataModel();
      value.PointList = GetPointList(openXmlElement);
      value.ConnectionList = GetConnectionList(openXmlElement);
      value.Background = GetBackground(openXmlElement);
      value.Whole = GetWhole(openXmlElement);
      value.DataModelExtensionList = GetDataModelExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.DataModel? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.DataModel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPointList(openXmlElement, value?.PointList);
      SetConnectionList(openXmlElement, value?.ConnectionList);
      SetBackground(openXmlElement, value?.Background);
      SetWhole(openXmlElement, value?.Whole);
      SetDataModelExtensionList(openXmlElement, value?.DataModelExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
