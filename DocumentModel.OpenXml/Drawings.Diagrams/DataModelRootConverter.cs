using DocumentModel.Drawings.Diagrams;
using DataModelRoot = DocumentFormat.OpenXml.Drawing.Diagrams.DataModelRoot;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Data Model.
/// </summary>
public static class DataModelRootConverter
{
  /// <summary>
  ///   Point List.
  /// </summary>
  public static PointList? GetPointList(DataModelRoot? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PointList>();
    if (itemElement != null)
      return PointListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPointList(DataModelRoot? openXmlElement, PointList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PointList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PointListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.PointList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Connection List.
  /// </summary>
  public static ConnectionList? GetConnectionList(DataModelRoot? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList>();
    if (itemElement != null)
      return ConnectionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetConnectionList(DataModelRoot? openXmlElement, ConnectionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConnectionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Background Formatting.
  /// </summary>
  public static Background? GetBackground(DataModelRoot? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Background>();
    if (itemElement != null)
      return BackgroundConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackground(DataModelRoot? openXmlElement, Background? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Background>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Background>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Whole E2O Formatting.
  /// </summary>
  public static Whole? GetWhole(DataModelRoot? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Whole>();
    if (itemElement != null)
      return WholeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWhole(DataModelRoot? openXmlElement, Whole? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Whole>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WholeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Whole>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DataModelExtensionList.
  /// </summary>
  public static DataModelExtensionList? GetDataModelExtensionList(DataModelRoot? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList>();
    if (itemElement != null)
      return DataModelExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataModelExtensionList(DataModelRoot? openXmlElement, DataModelExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataModelExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.DataModelRoot? CreateModelElement(DataModelRoot? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.DataModelRoot();
      value.PointList = GetPointList(openXmlElement);
      value.ConnectionList = GetConnectionList(openXmlElement);
      value.Background = GetBackground(openXmlElement);
      value.Whole = GetWhole(openXmlElement);
      value.DataModelExtensionList = GetDataModelExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.DataModelRoot? value)
    where OpenXmlElementType : DataModelRoot, new()
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