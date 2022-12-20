namespace DocumentModel.Drawings;

/// <summary>
/// Audio from CD.
/// </summary>
public partial class AudioFromCDImpl: ModelElementImpl, AudioFromCD
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.AudioFromCD? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AudioFromCD?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public AudioFromCDImpl(): base() {}
  
  public AudioFromCDImpl(DocumentFormat.OpenXml.Drawing.AudioFromCD openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Audio Start Time.
  /// </summary>
  public DocumentModel.Drawings.AudioCDTimeType? StartTime
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AudioCDTimeType>();
        if (item != null)
          return new DocumentModel.Drawings.AudioCDTimeTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AudioCDTimeType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.AudioCDTimeTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Audio End Time.
  /// </summary>
  public DocumentModel.Drawings.AudioCDTimeType? EndTime
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AudioCDTimeType>();
        if (item != null)
          return new DocumentModel.Drawings.AudioCDTimeTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AudioCDTimeType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.AudioCDTimeTypeImpl)?.OpenXmlElement;
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
