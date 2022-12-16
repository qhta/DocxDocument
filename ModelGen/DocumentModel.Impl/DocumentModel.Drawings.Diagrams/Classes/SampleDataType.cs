namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the SampleDataType Class.
/// </summary>
public class SampleDataTypeImpl: ModelElementImpl, SampleDataType
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SampleDataTypeImpl(): base() {}
  
  public SampleDataTypeImpl(DocumentFormat.OpenXml.Drawing.Diagrams.SampleDataType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Use Default
  /// </summary>
  public Boolean? UseDefault
  {
    get => (System.Boolean?)OpenXmlElement?.UseDefault?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UseDefault = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Data Model.
  /// </summary>
  public virtual DocumentModel.Drawings.Diagrams.DataModel? DataModel
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.DataModelImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.DataModelImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
