namespace DocumentModel.Properties;

/// <summary>
/// Application Specific File Properties.
/// </summary>
public partial class ExtendedPropertiesImpl: ModelElementImpl, ExtendedProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.ExtendedProperties.Properties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.ExtendedProperties.Properties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ExtendedPropertiesImpl(): base() {}
  
  public ExtendedPropertiesImpl(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Name of Document Template.
  /// </summary>
  public String? Template
  {
    get => (System.String?)OpenXmlElement?.Template?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Template != null)
        {
          if (value is not null)
            OpenXmlElement.Template.Text = value;
          else
            OpenXmlElement.Template = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Template = new DocumentFormat.OpenXml.ExtendedProperties.Template{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Name of Manager.
  /// </summary>
  public String? Manager
  {
    get => (System.String?)OpenXmlElement?.Manager?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Manager != null)
        {
          if (value is not null)
            OpenXmlElement.Manager.Text = value;
          else
            OpenXmlElement.Manager = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Manager = new DocumentFormat.OpenXml.ExtendedProperties.Manager{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Name of Company.
  /// </summary>
  public String? Company
  {
    get => (System.String?)OpenXmlElement?.Company?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Company != null)
        {
          if (value is not null)
            OpenXmlElement.Company.Text = value;
          else
            OpenXmlElement.Company = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Company = new DocumentFormat.OpenXml.ExtendedProperties.Company{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Total Number of Pages.
  /// </summary>
  public String? Pages
  {
    get => (System.String?)OpenXmlElement?.Pages?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Pages != null)
        {
          if (value is not null)
            OpenXmlElement.Pages.Text = value;
          else
            OpenXmlElement.Pages = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Pages = new DocumentFormat.OpenXml.ExtendedProperties.Pages{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Word Count.
  /// </summary>
  public String? Words
  {
    get => (System.String?)OpenXmlElement?.Words?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Words != null)
        {
          if (value is not null)
            OpenXmlElement.Words.Text = value;
          else
            OpenXmlElement.Words = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Words = new DocumentFormat.OpenXml.ExtendedProperties.Words{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Total Number of Characters.
  /// </summary>
  public String? Characters
  {
    get => (System.String?)OpenXmlElement?.Characters?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Characters != null)
        {
          if (value is not null)
            OpenXmlElement.Characters.Text = value;
          else
            OpenXmlElement.Characters = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Characters = new DocumentFormat.OpenXml.ExtendedProperties.Characters{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Intended Format of Presentation.
  /// </summary>
  public String? PresentationFormat
  {
    get => (System.String?)OpenXmlElement?.PresentationFormat?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PresentationFormat != null)
        {
          if (value is not null)
            OpenXmlElement.PresentationFormat.Text = value;
          else
            OpenXmlElement.PresentationFormat = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PresentationFormat = new DocumentFormat.OpenXml.ExtendedProperties.PresentationFormat{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Number of Lines.
  /// </summary>
  public String? Lines
  {
    get => (System.String?)OpenXmlElement?.Lines?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Lines != null)
        {
          if (value is not null)
            OpenXmlElement.Lines.Text = value;
          else
            OpenXmlElement.Lines = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Lines = new DocumentFormat.OpenXml.ExtendedProperties.Lines{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Total Number of Paragraphs.
  /// </summary>
  public String? Paragraphs
  {
    get => (System.String?)OpenXmlElement?.Paragraphs?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Paragraphs != null)
        {
          if (value is not null)
            OpenXmlElement.Paragraphs.Text = value;
          else
            OpenXmlElement.Paragraphs = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Paragraphs = new DocumentFormat.OpenXml.ExtendedProperties.Paragraphs{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Slides Metadata Element.
  /// </summary>
  public String? Slides
  {
    get => (System.String?)OpenXmlElement?.Slides?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Slides != null)
        {
          if (value is not null)
            OpenXmlElement.Slides.Text = value;
          else
            OpenXmlElement.Slides = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Slides = new DocumentFormat.OpenXml.ExtendedProperties.Slides{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Number of Slides Containing Notes.
  /// </summary>
  public String? Notes
  {
    get => (System.String?)OpenXmlElement?.Notes?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Notes != null)
        {
          if (value is not null)
            OpenXmlElement.Notes.Text = value;
          else
            OpenXmlElement.Notes = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Notes = new DocumentFormat.OpenXml.ExtendedProperties.Notes{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Total Edit Time Metadata Element.
  /// </summary>
  public String? TotalTime
  {
    get => (System.String?)OpenXmlElement?.TotalTime?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TotalTime != null)
        {
          if (value is not null)
            OpenXmlElement.TotalTime.Text = value;
          else
            OpenXmlElement.TotalTime = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TotalTime = new DocumentFormat.OpenXml.ExtendedProperties.TotalTime{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Number of Hidden Slides.
  /// </summary>
  public String? HiddenSlides
  {
    get => (System.String?)OpenXmlElement?.HiddenSlides?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.HiddenSlides != null)
        {
          if (value is not null)
            OpenXmlElement.HiddenSlides.Text = value;
          else
            OpenXmlElement.HiddenSlides = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.HiddenSlides = new DocumentFormat.OpenXml.ExtendedProperties.HiddenSlides{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Total Number of Multimedia Clips.
  /// </summary>
  public String? MultimediaClips
  {
    get => (System.String?)OpenXmlElement?.MultimediaClips?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MultimediaClips != null)
        {
          if (value is not null)
            OpenXmlElement.MultimediaClips.Text = value;
          else
            OpenXmlElement.MultimediaClips = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MultimediaClips = new DocumentFormat.OpenXml.ExtendedProperties.MultimediaClips{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Thumbnail Display Mode.
  /// </summary>
  public String? ScaleCrop
  {
    get => (System.String?)OpenXmlElement?.ScaleCrop?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ScaleCrop != null)
        {
          if (value is not null)
            OpenXmlElement.ScaleCrop.Text = value;
          else
            OpenXmlElement.ScaleCrop = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ScaleCrop = new DocumentFormat.OpenXml.ExtendedProperties.ScaleCrop{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Heading Pairs.
  /// </summary>
  public DocumentModel.Properties.HeadingPairs? HeadingPairs
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs>();
        if (item != null)
          return new DocumentModel.Properties.HeadingPairsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Properties.HeadingPairsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Part Titles.
  /// </summary>
  public DocumentModel.Properties.TitlesOfParts? TitlesOfParts
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts>();
        if (item != null)
          return new DocumentModel.Properties.TitlesOfPartsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Properties.TitlesOfPartsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Links Up-to-Date.
  /// </summary>
  public String? LinksUpToDate
  {
    get => (System.String?)OpenXmlElement?.LinksUpToDate?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LinksUpToDate != null)
        {
          if (value is not null)
            OpenXmlElement.LinksUpToDate.Text = value;
          else
            OpenXmlElement.LinksUpToDate = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LinksUpToDate = new DocumentFormat.OpenXml.ExtendedProperties.LinksUpToDate{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Number of Characters (With Spaces).
  /// </summary>
  public String? CharactersWithSpaces
  {
    get => (System.String?)OpenXmlElement?.CharactersWithSpaces?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.CharactersWithSpaces != null)
        {
          if (value is not null)
            OpenXmlElement.CharactersWithSpaces.Text = value;
          else
            OpenXmlElement.CharactersWithSpaces = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.CharactersWithSpaces = new DocumentFormat.OpenXml.ExtendedProperties.CharactersWithSpaces{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Shared Document.
  /// </summary>
  public String? SharedDocument
  {
    get => (System.String?)OpenXmlElement?.SharedDocument?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.SharedDocument != null)
        {
          if (value is not null)
            OpenXmlElement.SharedDocument.Text = value;
          else
            OpenXmlElement.SharedDocument = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.SharedDocument = new DocumentFormat.OpenXml.ExtendedProperties.SharedDocument{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Relative Hyperlink Base.
  /// </summary>
  public String? HyperlinkBase
  {
    get => (System.String?)OpenXmlElement?.HyperlinkBase?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.HyperlinkBase != null)
        {
          if (value is not null)
            OpenXmlElement.HyperlinkBase.Text = value;
          else
            OpenXmlElement.HyperlinkBase = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.HyperlinkBase = new DocumentFormat.OpenXml.ExtendedProperties.HyperlinkBase{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Hyperlink List.
  /// </summary>
  public DocumentModel.Properties.HyperlinkList? HyperlinkList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList>();
        if (item != null)
          return new DocumentModel.Properties.HyperlinkListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Properties.HyperlinkListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Hyperlinks Changed.
  /// </summary>
  public String? HyperlinksChanged
  {
    get => (System.String?)OpenXmlElement?.HyperlinksChanged?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.HyperlinksChanged != null)
        {
          if (value is not null)
            OpenXmlElement.HyperlinksChanged.Text = value;
          else
            OpenXmlElement.HyperlinksChanged = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.HyperlinksChanged = new DocumentFormat.OpenXml.ExtendedProperties.HyperlinksChanged{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Digital Signature.
  /// </summary>
  public DocumentModel.Properties.DigitalSignature? DigitalSignature
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature>();
        if (item != null)
          return new DocumentModel.Properties.DigitalSignatureImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Properties.DigitalSignatureImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Application Name.
  /// </summary>
  public String? Application
  {
    get => (System.String?)OpenXmlElement?.Application?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Application != null)
        {
          if (value is not null)
            OpenXmlElement.Application.Text = value;
          else
            OpenXmlElement.Application = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Application = new DocumentFormat.OpenXml.ExtendedProperties.Application{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Application Version.
  /// </summary>
  public String? ApplicationVersion
  {
    get => (System.String?)OpenXmlElement?.ApplicationVersion?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ApplicationVersion != null)
        {
          if (value is not null)
            OpenXmlElement.ApplicationVersion.Text = value;
          else
            OpenXmlElement.ApplicationVersion = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ApplicationVersion = new DocumentFormat.OpenXml.ExtendedProperties.ApplicationVersion{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Document Security.
  /// </summary>
  public String? DocumentSecurity
  {
    get => (System.String?)OpenXmlElement?.DocumentSecurity?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.DocumentSecurity != null)
        {
          if (value is not null)
            OpenXmlElement.DocumentSecurity.Text = value;
          else
            OpenXmlElement.DocumentSecurity = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.DocumentSecurity = new DocumentFormat.OpenXml.ExtendedProperties.DocumentSecurity{ Text = value };
        }
      }
    }
  }
  
}
