namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Data Model.
/// </summary>
public partial class DataModelImpl: ModelElementImpl, DataModel
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.DataModel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.DataModel?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DataModelImpl(): base() {}
  
  public DataModelImpl(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Point List.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.PointList? PointList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PointList>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.PointListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PointList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.PointListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Connection List.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ConnectionList? ConnectionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.ConnectionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.ConnectionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Background Formatting.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.Background? Background
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Background>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.BackgroundImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Background>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.BackgroundImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Whole E2O Formatting.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.Whole? Whole
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Whole>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.WholeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Whole>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.WholeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// DataModelExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.DataModelExtensionList? DataModelExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.DataModelExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.DataModelExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
