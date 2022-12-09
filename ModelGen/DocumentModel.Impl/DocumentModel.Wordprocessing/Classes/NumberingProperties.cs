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
  
  /// <summary>
  /// Numbering Level Reference.
  /// </summary>
  public Int32? NumberingLevelReference
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingLevelReference>();
        return (Int32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingLevelReference>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.Int32?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.NumberingLevelReference{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Numbering Definition Instance Reference.
  /// </summary>
  public Int32? NumberingId
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingId>();
        return (Int32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingId>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.Int32?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.NumberingId{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Previous Paragraph Numbering Properties.
  /// </summary>
  public NumberingChange? NumberingChange
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Inserted Numbering Properties.
  /// </summary>
  public TrackChangeType? Inserted
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
