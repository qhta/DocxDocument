namespace DocumentModel.Math;

/// <summary>
/// Matrix Column.
/// </summary>
public partial class MatrixColumnImpl: ModelElementImpl, MatrixColumn
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Math.MatrixColumn? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.MatrixColumn?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public MatrixColumnImpl(): base() {}
  
  public MatrixColumnImpl(DocumentFormat.OpenXml.Math.MatrixColumn openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Matrix Column Properties.
  /// </summary>
  public DocumentModel.Math.MatrixColumnProperties? MatrixColumnProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumnProperties>();
        if (item != null)
          return new DocumentModel.Math.MatrixColumnPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumnProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.MatrixColumnPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
