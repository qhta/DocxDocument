namespace DocumentModel.Wordprocessing.DrawingShape;

/// <summary>
/// Defines the NonVisualConnectorProperties Class.
/// </summary>
public partial class NonVisualConnectorPropertiesImpl: ModelElementImpl, NonVisualConnectorProperties
{
  public DocumentFormat.OpenXml.Office2010.Word.DrawingShape.NonVisualConnectorProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.DrawingShape.NonVisualConnectorProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualConnectorPropertiesImpl(): base() {}
  
  public NonVisualConnectorPropertiesImpl(DocumentFormat.OpenXml.Office2010.Word.DrawingShape.NonVisualConnectorProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Connection Shape Locks.
  /// </summary>
  public DocumentModel.Drawings.ConnectionShapeLocks? ConnectionShapeLocks
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks>();
        if (item != null)
          return new DocumentModel.Drawings.ConnectionShapeLocksImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ConnectionShapeLocksImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Connection Start.
  /// </summary>
  public DocumentModel.Drawings.ConnectionType? StartConnection
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ConnectionType>();
        if (item != null)
          return new DocumentModel.Drawings.ConnectionTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ConnectionType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ConnectionTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Connection End.
  /// </summary>
  public DocumentModel.Drawings.ConnectionType? EndConnection
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ConnectionType>();
        if (item != null)
          return new DocumentModel.Drawings.ConnectionTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ConnectionType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ConnectionTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
