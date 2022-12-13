namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the NumberingProperties Class.
/// </summary>
public class NumberingPropertiesImpl: ModelElementImpl, NumberingProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.NumberingProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.NumberingProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Inserted Numbering Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.TrackChangeType? Inserted
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
