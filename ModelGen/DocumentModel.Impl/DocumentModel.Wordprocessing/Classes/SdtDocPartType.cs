namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtDocPartType Class.
/// </summary>
public class SdtDocPartTypeImpl: ModelElementImpl, SdtDocPartType
{
  public DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtDocPartType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Document Part Gallery Filter.
  /// </summary>
  public virtual String? DocPartGallery
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartGallery>();
        return (String?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartGallery>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.String?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.DocPartGallery{ Val = (System.String?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Document Part Category Filter.
  /// </summary>
  public virtual String? DocPartCategory
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartCategory>();
        return (String?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartCategory>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.String?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.DocPartCategory{ Val = (System.String?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Built-In Document Part.
  /// </summary>
  public virtual Boolean? DocPartUnique
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartUnique>();
        return (Boolean?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartUnique>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.Boolean?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.DocPartUnique{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
