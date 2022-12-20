namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Text Properties.
/// </summary>
public partial class TextPropertiesImpl: ModelElementImpl, TextProperties
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextPropertiesImpl(): base() {}
  
  public TextPropertiesImpl(DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Apply 3D shape properties.
  /// </summary>
  public DocumentModel.Drawings.Shape3DType? Shape3DType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
        if (item != null)
          return new DocumentModel.Drawings.Shape3DTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Shape3DTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// No text in 3D scene.
  /// </summary>
  public DocumentModel.Drawings.FlatText? FlatText
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FlatText>();
        if (item != null)
          return new DocumentModel.Drawings.FlatTextImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FlatText>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.FlatTextImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
