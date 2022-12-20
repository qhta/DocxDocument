namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the NumberingProperties Class.
/// </summary>
public partial class NumberingPropertiesImpl: ModelElementImpl, NumberingProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.NumberingProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.NumberingProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public NumberingPropertiesImpl(): base() {}
  
  public NumberingPropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.NumberingProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Numbering Level Reference.
  /// </summary>
  public Int32? NumberingLevelReference
  {
    get => (System.Int32?)OpenXmlElement?.NumberingLevelReference?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.NumberingLevelReference != null)
        {
          if (value is not null)
            OpenXmlElement.NumberingLevelReference.Val = (System.Int32?)value;
          else
            OpenXmlElement.NumberingLevelReference = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.NumberingLevelReference = new DocumentFormat.OpenXml.Wordprocessing.NumberingLevelReference{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Numbering Definition Instance Reference.
  /// </summary>
  public Int32? NumberingId
  {
    get => (System.Int32?)OpenXmlElement?.NumberingId?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.NumberingId != null)
        {
          if (value is not null)
            OpenXmlElement.NumberingId.Val = (System.Int32?)value;
          else
            OpenXmlElement.NumberingId = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.NumberingId = new DocumentFormat.OpenXml.Wordprocessing.NumberingId{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Previous Paragraph Numbering Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.NumberingChange? NumberingChange
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingChange>();
        if (item != null)
          return new DocumentModel.Wordprocessing.NumberingChangeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingChange>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.NumberingChangeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Inserted Numbering Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.TrackChangeType? Inserted
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TrackChangeType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.TrackChangeTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TrackChangeType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.TrackChangeTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
